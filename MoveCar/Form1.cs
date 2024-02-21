using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MoveCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            road.Controls.Add(car);
            car.Top = 955;
        }

        private int car_y = 355, car_top = 355, speed_car = 1, move_car = 4, next_barrier = 300, a;
        private bool start_move = false, in_right = false, new_barriers = true;

        private Random random = new Random();
        private bool[] new_barriers_law = new bool[4] { true, true, true, true };
        private int[,] barriers_speed = new int[2, 4] { { 0, 0, 0, 0 }, { -90, -90, -90, -90 } };
        private int[] stop_barriers = { 0, 1, 2, 3 };

        private void dilayCar_Elapsed(object sender, ElapsedEventArgs e)
        {
            road.Top += speed_car;
            car.Top = car_y + (road.Top * -1);
            if (road.Top >= 0)
            {
                road.Top = -600;
                car.Top = car_y + (road.Top * -1);
            }

            car_top = car.Top + road.Top;

            barrier1.Top += barriers_speed[0, 0];
            barrier2.Top += barriers_speed[0, 1];
            barrier3.Top += barriers_speed[0, 2];
            barrier4.Top += barriers_speed[0, 3];

            barriers_speed[1, 0] = barrier1.Top;
            barriers_speed[1, 1] = barrier2.Top;
            barriers_speed[1, 2] = barrier3.Top;
            barriers_speed[1, 3] = barrier4.Top;

            if (start_move)
            {
                if (new_barriers)
                {
                    a = stop_barriers[random.Next(0, stop_barriers.Length)];
                    barriers_speed[0, a] = speed_car;
                    stop_barriers = stop_barriers.Where(val => val != a).ToArray();
                    new_barriers = false;
                    next_barrier = random.Next(180, 450);
                }
            }

            if (car_top <= barrier1.Top + 90 && car_top + 170 >= barrier1.Top + 20)
            {
                if (car.Left + 84 > barrier1.Left)
                {
                    message1.Text = "شما باختید!";
                    message1.Visible = true;
                    message2.Visible = true;
                    dilayCar.Enabled = false;
                    move_car = 0;
                }
            }

            if (barrier1.Top >= next_barrier && new_barriers_law[0])
            {
                new_barriers_law[0] = false;
                new_barriers = true;
            }

            if (barrier1.Top >= 600)
            {
                barriers_speed[0, 0] = 0;
                barrier1.Top = -90;
                Array.Resize(ref stop_barriers, stop_barriers.Length + 1);
                stop_barriers[stop_barriers.Length - 1] = 0;
                new_barriers_law[0] = true;
            }


            if (car_top <= barrier2.Top + 90 && car_top + 170 >= barrier2.Top + 10)
            {
                if (car.Left + 84 > barrier2.Left)
                {
                    message1.Text = "شما باختید!";
                    message1.Visible = true;
                    message2.Visible = true;
                    dilayCar.Enabled = false;
                    move_car = 0;
                }
            }

            if (barrier2.Top >= next_barrier && new_barriers_law[1])
            {
                new_barriers_law[1] = false;
                new_barriers = true;
            }

            if (barrier2.Top >= 600)
            {
                barriers_speed[0, 1] = 0;
                barrier2.Top = -90;
                Array.Resize(ref stop_barriers, stop_barriers.Length + 1);
                stop_barriers[stop_barriers.Length - 1] = 1;
                new_barriers_law[1] = true;
            }


            if (car_top <= barrier3.Top + 90 && car_top + 170 >= barrier3.Top + 20)
            {
                if (car.Left + 16 < barrier3.Left + 90)
                {
                    message1.Text = "شما باختید!";
                    message1.Visible = true;
                    message2.Visible = true;
                    dilayCar.Enabled = false;
                    move_car = 0;
                }
            }

            if (barrier3.Top >= next_barrier && new_barriers_law[2])
            {
                new_barriers_law[2] = false;
                new_barriers = true;
            }

            if (barrier3.Top >= 600)
            {
                barriers_speed[0, 2] = 0;
                barrier3.Top = -90;
                Array.Resize(ref stop_barriers, stop_barriers.Length + 1);
                stop_barriers[stop_barriers.Length - 1] = 2;
                new_barriers_law[2] = true;
            }


            if (car_top <= barrier4.Top + 90 && car_top + 170 >= barrier4.Top + 30)
            {
                if (car.Left + 16 < barrier4.Left + 90)
                {
                    message1.Text = "شما باختید!";
                    message1.Visible = true;
                    message2.Visible = true;
                    dilayCar.Enabled = false;
                    move_car = 0;
                }
            }

            if (barrier4.Top >= next_barrier && new_barriers_law[3])
            {
                new_barriers_law[3] = false;
                new_barriers = true;
            }

            if (barrier4.Top >= 600)
            {
                barriers_speed[0, 3] = 0;
                barrier4.Top = -90;
                Array.Resize(ref stop_barriers, stop_barriers.Length + 1);
                stop_barriers[stop_barriers.Length - 1] = 3;
                new_barriers_law[3] = true;
            }
        }

        private void start_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (car_y > 340 && !(start_move))
                car_y -= 2;
            else
            {
                start_move = true;
                start.Interval = 10;
                speed_car = 4;

                if (car_y < 400)
                    car_y += 1;
                else
                {
                    start.Enabled = false;
                    in_right = false;
                }

                if (car.Left < 165)
                    car.Left += 1;
            }
        }

        private void moveCar_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!(start.Enabled))
            {
                if (in_right)
                {
                    if (car.Left > 45)
                    {
                        car.Left -= move_car;
                    }
                    else
                    {
                        moveCar.Enabled = false;
                    }
                }
                else
                {
                    if (car.Left < 165)
                    {
                        car.Left += move_car;
                    }
                    else
                    {
                        moveCar.Enabled = false;
                    }
                }
            }
            else
            {
                moveCar.Enabled = false;
            }
        }

        private void keyEvent_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent.Text = "";
            if (e.KeyCode == Keys.Space)
            {
            }
        }

        private void keyEvent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!(start_move))
                {
                    message1.Visible = false;
                    start.Enabled = true;
                }
                else
                {
                    in_right = !in_right;
                    moveCar.Enabled = true;
                }
            }

            if (e.KeyCode == Keys.R && start_move)
            {
                message1.Text = "برای شروع فاصله را بزنید.";
                message1.Visible = true;
                message2.Visible = false;
                car_y = 355;
                road.Top = -600;
                car.Top = car_y + (road.Top * -1);
                car.Left = 105;
                speed_car = 1;
                move_car = 4;
                in_right = false;
                start_move = false;
                moveCar.Enabled = false;
                barrier1.Top = -90;
                barrier2.Top = -90;
                barrier3.Top = -90;
                barrier4.Top = -90;
                barriers_speed = new int[2, 4] { { 0, 0, 0, 0 }, { -90, -90, -90, -90 } };
                stop_barriers = new int[] { 0, 1, 2, 3 };
                new_barriers = true;
                new_barriers_law = new bool[4] { true, true, true, true };
                dilayCar.Enabled = true;
            }
        }
    }
}