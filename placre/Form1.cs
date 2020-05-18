using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;


namespace placre
{
    public partial class Form1 : Form
    {
        List<PointLatLng> points;
        GMapOverlay polygons;
        GMapOverlay markers;

        Boolean mm = false; //Is a marker currently being moved?
        GMapMarker activeMarker = null; //Temporary marker to be moved and referenced for its position

        public Form1()
        {
            InitializeComponent();
            this.Text = "(Pl)Acre! 0.02a";
        }

        private void main_Load(object sender, EventArgs e)
        {
            main.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            main.DragButton = MouseButtons.Left;
            main.SetPositionByKeywords("Paris, France");

            markers = new GMapOverlay("markers");
            polygons = new GMapOverlay("polygons");
            points = new List<PointLatLng>();
            main.Overlays.Add(polygons);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main.SetPositionByKeywords("");
            polygons.Polygons.Clear();
            GMapPolygon polygon = new GMapPolygon(points, "Acre Plot");
            polygons.Polygons.Add(polygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            
        }

        private void main_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = main.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = main.FromLocalToLatLng(e.X, e.Y).Lng;
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(lat,lng),
                    GMarkerGoogleType.red_dot);
                
                polygons.Markers.Add(marker);
                points.Add(new PointLatLng(lat, lng));
            }
        }

        private void main_OnMarkerEnter(GMapMarker item)
        {
            if(mm == false)
            {
                activeMarker = item;
            }
        }

        private void main_OnMarkerLeave(GMapMarker item)
        {
            if(mm == false)
            {
                activeMarker = null;
            }
        }

        private void main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && mm)
            {
                mm = false;
                if (activeMarker.IsMouseOver == false)
                {
                    activeMarker = null;
                }
            }
        }

        private void main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left && main.IsMouseOverMarker)
            {
                mm = true;
            }
        }

        private void main_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left && mm)
            {
                var prevPos = activeMarker.Position;
                activeMarker.Position = main.FromLocalToLatLng(e.X, e.Y);
                for(int i = 0; i < points.Count; i++)
                {
                    if (points[i].Lat == prevPos.Lat && points[i].Lng == prevPos.Lng)
                    {
                        points[i] = activeMarker.Position;
                        polygons.Polygons.Clear();
                        GMapPolygon polygon = new GMapPolygon(points, "Acre Plot");
                        polygons.Polygons.Add(polygon);
                        polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                        polygon.Stroke = new Pen(Color.Red, 1);
                        break;
                    }
                }
            }
        }
    }
}
