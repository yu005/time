using System;
using System.Windows.Forms;

namespace time
{
    public partial class Form1 : Form
    {
        private Label timerLabel;
        private Button startButton;
        private System.Windows.Forms.Timer countdownTimer;
        private int secondsRemaining;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "�˼ƭp�ɾ�";

            timerLabel = new Label();
            timerLabel.Text = "�Ѿl���: 0";
            timerLabel.Location = new System.Drawing.Point(50, 50);
            timerLabel.AutoSize = true;

            startButton = new Button();
            startButton.Text = "�Ұʭ˼�";
            startButton.Location = new System.Drawing.Point(50, 100);
            startButton.Click += StartButton_Click;

            this.Controls.Add(timerLabel);
            this.Controls.Add(startButton);

            countdownTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1 second
            };
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Reset seconds remaining
            secondsRemaining = 100;
            // Start the countdown
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            secondsRemaining--;

            if (secondsRemaining >= 0)
            {
                // Update the timer label
                timerLabel.Text = "�Ѿl���: " + secondsRemaining.ToString();
            }
            else
            {
                // Time's up, stop the countdown
                countdownTimer.Stop();
                // Show a message box
                MessageBox.Show("�ɶ���I");
            }
        }
    }

    //[STAThread]
    //public static void Main()
    //{
    //    Application.EnableVisualStyles();
    //    Application.SetCompatibleTextRenderingDefault(false);
    //    Application.Run(new Form1());
    //}
}
