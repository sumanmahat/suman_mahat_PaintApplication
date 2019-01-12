using _7202708_PaintApplication.NewFolder1;
using MaterialSkin.Controls;
using Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _77202708_PaintApplication
{
    public partial class GraphicalProgramming: MaterialForm
    {
        //variable declear
        Pen pen = new Pen(Color.Black, 1);
        int xAxis = 0;
        int yAxis = 0;
        Rectangle rect;
        Point lineY;
        List<object> shapeList = new List<object>();
        List<Point> listPoint = new List<Point>();
        Graphics g;
        bool isDragging = false;
        string shape;
        ShapeFactory shapeFactory = new ShapeFactory();
        Shape shapes;

        public GraphicalProgramming()
        {
            InitializeComponent();
        }


        private void toolRectangle_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// to drag circle into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolCircle_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            lbl_circle.BackColor = Color.LightSlateGray;
            shape = "CIRCLE";
        }

        /// <summary>
        /// to fill circle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolFillCircle_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            toolFillCircle.BackColor = Color.LightSlateGray;
            shape = "FILL CIRCLE";
        }

        /// <summary>
        /// to drag polygon into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolPolygon_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            lbl_polygon.BackColor = Color.LightSlateGray;
            shape = "POLYGON";
        }

        private void toolFillPolygon_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            toolFillPolygon.BackColor = Color.LightSlateGray;
            shape = "FILL POLYGON";
        }

        /// <summary>
        /// to drag lline into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolLine_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            lbl_line.BackColor = Color.LightSlateGray;
            shape = "LINE";
        }

        /// <summary>
        /// to set color in label when click 
        /// </summary>
        private void ResetToolBar()
        {
            lbl_rectangle.BackColor = Color.DarkGray;
            toolFillRectangle.BackColor = Color.DarkGray;
            lbl_circle.BackColor = Color.DarkGray;
            toolFillCircle.BackColor = Color.DarkGray;
            lbl_polygon.BackColor = Color.DarkGray;
            toolFillPolygon.BackColor = Color.DarkGray;
            lbl_line.BackColor = Color.DarkGray;
            listPoint.Clear();
        }

        /// <summary>
        /// mouseDown event for x and y axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            xAxis = e.X; 
            yAxis = e.Y; 
        }

        /// <summary>
        /// mousemove event to draw line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging) return;
            int x = Math.Min(xAxis, e.X);
            int y = Math.Min(yAxis, e.Y);
            int width = Math.Max(xAxis, e.X) - Math.Min(xAxis, e.X);
            int height = Math.Max(yAxis, e.Y) - Math.Min(yAxis, e.Y);
            if (shape == "LINE") 
                lineY = e.Location; 
            else
                rect = new Rectangle(x, y, width, height);
            panelCanvas.Refresh(); 
        }

        /// <summary>
        /// drawing shapes from draging option into panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            int x = Math.Min(xAxis, e.X);
            int y = Math.Min(yAxis, e.Y);
            int width = Math.Max(xAxis, e.X) - Math.Min(xAxis, e.X);
            int height = Math.Max(yAxis, e.Y) - Math.Min(yAxis, e.Y);

            if (shape == "POLYGON") //Checking if we are drawing polygon
            {
                if (shapeList.Count == 0) //Checking if drawing panel is empty
                {
                    Polygon polygon = new Polygon(pen.Color, false);
                    polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                    shapeList.Add(polygon); //Adding polygon to the shapelist to draw inside the drawing panel
                    panelCanvas.Refresh();
                    return; //Returning because it's the first shape we are drawing. No need to go further
                }
                object obj = shapeList[shapeList.Count - 1]; //Getting the last object from the shapeList
                if (obj.GetType() == typeof(Polygon)) //Checking if it's polygon
                {
                    if (((Polygon)obj).isFilled) //Checking if it's filled polygon
                    {
                        Polygon polygon = new Polygon(pen.Color, false);
                        polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                        shapeList.Add(polygon);
                    }
                    else
                    {
                        Polygon polygon = UpdatePolygon(new Point(MousePosition.X, MousePosition.Y));
                        shapeList.RemoveAt(shapeList.Count - 1);
                        shapeList.Add(polygon);
                    }
                }
                else
                {
                    Polygon polygon = new Polygon(pen.Color, false);
                    polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                    shapeList.Add(polygon);
                }
                panelCanvas.Refresh();
            }
            else if (shape == "FILL POLYGON")
            {
                if (shapeList.Count == 0)
                {
                    Polygon polygon = new Polygon(pen.Color, false);
                    polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                    shapeList.Add(polygon);
                    panelCanvas.Refresh();
                    return;
                }
                object obj = shapeList[shapeList.Count - 1];
                if (obj.GetType() == typeof(Polygon))
                {
                    if (!((Polygon)obj).isFilled)
                    {
                        Polygon polygon = new Polygon(pen.Color, true);
                        polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                        shapeList.Add(polygon);
                    }
                    else
                    {
                        Polygon polygon = UpdatePolygon(new Point(MousePosition.X, MousePosition.Y));
                        shapeList.RemoveAt(shapeList.Count - 1);
                        shapeList.Add(polygon);
                    }
                }
                else
                {
                    Polygon polygon = new Polygon(pen.Color, true);
                    polygon.addPoint(new Point(MousePosition.X, MousePosition.Y));
                    shapeList.Add(polygon);
                }
                panelCanvas.Refresh();
            }
            else if (shape == "RECTANGLE")
            {
                shapes = shapeFactory.getShape("RECTANGLE");
                shapes.SetParam(xAxis, yAxis, width, height, pen.Color, false, "", lineY, lineY);
                shapeList.Add(shapes);
            }
            else if (shape == "FILL RECTANGLE")
            {
                shapes = shapeFactory.getShape("RECTANGLE");
                shapes.SetParam(xAxis, yAxis, width, height, pen.Color, true, "", lineY, lineY);
                shapeList.Add(shapes);
            }
            else if (shape == "CIRCLE")
            {
                shapes = shapeFactory.getShape("CIRCLE");
                shapes.SetParam(xAxis, yAxis, width, 0, pen.Color, false, "", lineY, lineY);
                shapeList.Add(shapes);
            }
            else if (shape == "FILL CIRCLE")
            {
                shapes = shapeFactory.getShape("CIRCLE");
                shapes.SetParam(xAxis, yAxis, width, 0, pen.Color, true, "", lineY, lineY);
                shapeList.Add(shapes);
            }
            else if (shape == "LINE")
            {
                shapes = shapeFactory.getShape("LINE");
                shapes.SetParam(xAxis, yAxis, 0, 0, pen.Color, false, "", new Point(xAxis, yAxis), lineY);
                shapeList.Add(shapes);
            }
            panelCanvas.Refresh();
        }


        /// <summary>
        /// updating polydon shape
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private Polygon UpdatePolygon(Point point)
        {
            Polygon tmpPolygon = (Polygon)shapeList[shapeList.Count - 1]; //Get's last object form shapeList which is polygon
            Polygon polygon = new Polygon(tmpPolygon.color, tmpPolygon.isFilled); //Creating new polygon object
            foreach (Point p in tmpPolygon.getPoint())
            {
                polygon.addPoint(p); //Iterating through points inside previous polygon and adding all points to new polygon
            }
            polygon.addPoint(point); //Adding new points to new polygon
            return polygon; //Returning the new polygon object
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphicalProgramming_Load(object sender, EventArgs e)
        {
            xAxis = panelCanvas.Width / 2;
            yAxis = panelCanvas.Height / 2;
            panelCanvas.Paint += new PaintEventHandler(panelCanvas_Paint);
        }


        /// <summary>
        /// dragging the shape into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            //Initiating graphic object if it's null
            if (g == null) g = panelCanvas.CreateGraphics();
            Font fy = new Font("Above The Sky", 10, FontStyle.Bold);
            Brush br = new SolidBrush(pen.Color);

            //This if block shows the shape while dragging the mouse            
            if (isDragging)
            {
                switch (shape)
                {
                    case "CIRCLE":
                        g.DrawEllipse(pen, rect);
                        break;
                    case "RECTANGLE":
                        g.DrawRectangle(pen, rect);
                        break;
                    case "FILL RECTANGLE":
                        g.FillRectangle(br, rect);
                        break;
                    case "FILL CIRCLE":
                        g.FillEllipse(br, rect);
                        break;
                    case "POLYGON":
                        if (listPoint.Count < 2) return;
                        g.DrawPolygon(pen, listPoint.ToArray());
                        break;
                    case "FILL POLYGON":
                        if (listPoint.Count < 2) return;
                        g.FillPolygon(br, listPoint.ToArray());
                        break;
                    case "LINE":
                        g.DrawLine(pen, new Point(xAxis, yAxis), lineY);
                        break;
                }

            }
            else //This is the actual code for drawing inside the panel
            {
                if (shapeList.Count > 0) //Checking if user has drawn anything inside the panel
                {
                    foreach (object obj in shapeList) //Looping through drawing objects to display
                    {
                        if (obj.GetType() == typeof(Polygon))
                        {
                            Polygon polygon = (Polygon)obj; //Type casting obj to Polygon
                            if (polygon.getPoint().Count > 2) //Checking if user has set more than 2 points
                            {
                                if (polygon.isFilled) //Checking if it's a filled polygon
                                {
                                    Brush pbr = new SolidBrush(polygon.color);
                                    g.FillPolygon(pbr, polygon.getPoint().ToArray());
                                    pbr.Dispose();
                                }
                                else
                                {
                                    Pen pen = new Pen(polygon.color);
                                    g.DrawPolygon(pen, polygon.getPoint().ToArray());
                                    pen.Dispose();
                                }
                            }
                        }
                        else
                        {
                            shapes = (Shape)obj;
                            shapes.Draw(g);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// read and execute command from textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCommand_KeyUp(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter)
                {
                    string cmd = txtCommand.Text;
                    if (cmd.ToLower().Equals("open")) //to open dialogbox from Pc
                    {
                        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            label1.Text = openFileDialog1.FileName;
                            txtCommand.Text = File.ReadAllText(label1.Text);
                        }
                    }
                    if (cmd.ToLower().Equals("save"))
                    {
                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog1.FileName, txtCommand.Text);
                            MessageBox.Show("File save succesfully");

                        }
                    }

                    if (cmd.ToLower().Equals("help")) //to open helpcommand form
                    {
                        HelpCommand help = new HelpCommand();
                        help.Show();
                        return;
                    }

                    if (!cmd.Contains(" "))
                    {
                        ShowStatus("Wrong command!! See help Command", false);
                        return;
                    }
                    string initialCommand = cmd.Split(' ')[0]; //Getting starting point 

                    if (initialCommand.ToLower().Equals("drawto"))
                    {
                        if (!cmd.Contains(","))
                        {
                            ShowStatus("Wrong command: Eg. DrawTo 100,150", false);
                            return;
                        }
                        string xyPos = cmd.Split(' ')[1];
                        xAxis = int.Parse(xyPos.Split(',')[0]);
                        yAxis = int.Parse(xyPos.Split(',')[1]);
                        ShowStatus("Position successfully set to " + xAxis + " and " + yAxis, true);
                    }
                    else if (initialCommand.ToLower().Equals("moveto"))
                    {
                        if (!cmd.Contains(","))
                        {
                            ShowStatus("Wrong command: Eg. MoveTo 100,150", false);
                            return;
                        }
                        string xyPos = cmd.Split(' ')[1];
                        xAxis = int.Parse(xyPos.Split(',')[0]);
                        yAxis = int.Parse(xyPos.Split(',')[1]);
                        ShowStatus("Position successfully moved to " + xAxis + " and " + yAxis, true);
                    }
                    else if (initialCommand.ToLower().Equals("drawcircle"))  //to draw circle from command
                    {
                        int radius = int.Parse(cmd.Split(' ')[1]);
                        shapes = shapeFactory.getShape("CIRCLE");
                        shapes.SetParam(xAxis, yAxis, radius, 0, pen.Color, false, "", lineY, lineY);
                        shapeList.Add(shapes);
                        ShowStatus("Cirle drawn succesfully.", true);

                    }
                    else if (initialCommand.ToLower().Equals("drawrectangle")) //to draw rectangle 
                    {
                        if (!cmd.Contains(","))
                        {
                            ShowStatus("Wrong command: Eg. DrawRectangle 100,150", false);
                            return;
                        }
                        string wh = cmd.Split(' ')[1];
                        int width = int.Parse(wh.Split(',')[0]);
                        int height = int.Parse(wh.Split(',')[1]);
                        shapes = shapeFactory.getShape("RECTANGLE");
                        shapes.SetParam(xAxis, yAxis, width, height, pen.Color, false, "", lineY, lineY);
                        shapeList.Add(shapes);
                        ShowStatus("Rectangle drawn succesfully.", true);

                    }
                    else if (initialCommand.ToLower().Equals("string"))
                    {
                        string text = cmd.Split(' ')[1];
                        shapes = shapeFactory.getShape("STRING");
                        shapes.SetParam(xAxis, yAxis, 0, 0, pen.Color, false, text, lineY, lineY);
                        shapeList.Add(shapes);
                        ShowStatus("String has been drawn.", true);
                    }
                    else if (initialCommand.ToLower().Equals("repeat"))  //to repeat circle/rectanlge many times with given radius
                    {
                        string[] cmdList = cmd.Split(' ');
                        if (cmdList.Length != 5)
                        {
                            ShowStatus("Wrong command: Eg. repeat 4 circle radius +10", false);
                            return;
                        }
                        int counter = int.Parse(cmdList[1]);
                        string shapeName = cmdList[2];
                        int radius = int.Parse(cmdList[4].Split('+')[1]);
                        int midXPanel = panelCanvas.Width / 2;
                        int midYPanel = panelCanvas.Height / 2;


                        int circleRadius = 50;
                        for (int i = 0; i < counter; i++)   //using loop to draw shapes
                        {
                            xAxis = midXPanel - (circleRadius / 2);
                            yAxis = midYPanel - (circleRadius / 2);

                            if (shapeName.ToLower().Equals("drawcircle"))
                            {
                                shapes = shapeFactory.getShape("CIRCLE");
                                shapes.SetParam(xAxis, yAxis, circleRadius, 0, pen.Color, false, "", lineY, lineY);
                                shapeList.Add(shapes);
                            }
                            else if (shapeName.ToLower().Equals("drawrectangle"))
                            {
                                shapes = shapeFactory.getShape("RECTANGLE");
                                shapes.SetParam(xAxis, yAxis, circleRadius, circleRadius, pen.Color, false, "", lineY, lineY);
                                shapeList.Add(shapes);
                            }
                            else
                            {
                                ShowStatus("Wrong command: Shape name is invalid!!!", false);
                                return;
                            }
                            circleRadius += radius;
                        }
                        ShowStatus("Command executed successfully!!!", true);
                    }
                    else if (initialCommand.ToLower().Equals("drawline")) //to draw line
                    {
                        if (!cmd.Contains(","))
                        {
                            ShowStatus("Wrong command: Eg. Line x1,y1,x2,y2", false);
                            return;
                        }
                        string[] xyPos = cmd.Split(' ')[1].Split(',');
                        if (xyPos.Length < 4)
                        {
                            ShowStatus("Wrong command: Eg. Line x1,y1,x2,y2", false);
                            return;
                        }
                        xAxis = int.Parse(xyPos[0]);
                        yAxis = int.Parse(xyPos[1]);
                        int y1 = int.Parse(xyPos[2]);
                        int y2 = int.Parse(xyPos[3]);
                        lineY = new Point(y1, y2);
                        shapes = shapeFactory.getShape("LINE");
                        shapes.SetParam(xAxis, yAxis, 0, 0, pen.Color, false, "", new Point(xAxis, yAxis), lineY);
                        shapeList.Add(shapes);
                        ShowStatus("Line has been drawn.", true);
                    }
                    else if (initialCommand.ToLower().Equals("drawpolygon")) //to draw polygon
                    {
                        string tmp1 = cmd.Split('[')[1];
                        string tmp2 = tmp1.Split(']')[0];
                        string[] points = tmp2.Split(',');
                        if (!cmd.Contains(","))
                        {
                            ShowStatus("Wrong command: Eg. Polygon [500:500,200:200,240:450]", false);
                            return;
                        }
                        Polygon polygon = new Polygon(pen.Color, false);
                        foreach (string point in points)
                        {
                            int x = int.Parse(point.Split(':')[0]);
                            int y = int.Parse(point.Split(':')[1]);
                            polygon.addPoint(new Point(x, y));
                        }
                        shapeList.Add(polygon);
                        ShowStatus("Polygon has been drawn.", true);
                    }
                    else
                    {
                        ShowStatus("Wrong command!!!", false);
                    }

                    panelCanvas.Invalidate();
                    panelCanvas.Refresh();
                    txtCommand.Text = "";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// to show command message
        /// </summary>
        /// <param name="status"></param>
        /// <param name="isSuccessful"></param>
        private void ShowStatus(string status, bool isSuccessful)
        {
            lbl_command.Text = status;
            lbl_command.ForeColor = (isSuccessful) ? Color.Green : Color.Red;
        }

        /// <summary>
        /// event to clear shapes from panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            txtCommand.Clear();
            lbl_command.Text = "";
            panelCanvas.Invalidate();
        }

        /// <summary>
        /// event to open dialog from PC to select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    label1.Text = openFileDialog1.FileName;
                    txtCommand.Text = File.ReadAllText(label1.Text);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        /// <summary>
        /// event to save text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtCommand.Text);
                    MessageBox.Show("File save succesfully");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to save program");
            }
           
        }

        /// <summary>
        /// event to open color dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    lbl_color.BackColor = colorDialog1.Color;
                    pen.Color = colorDialog1.Color;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to choose color");
            }
        }

        /// <summary>
        ///event  to drag and draw rectangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rectangle_Click(object sender, EventArgs e)
        {
            ResetToolBar();
            lbl_rectangle.BackColor = Color.LightSlateGray;
            shape = "RECTANGLE";
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            HelpCommand help = new HelpCommand();
            help.ShowDialog();
        }
    }
}
