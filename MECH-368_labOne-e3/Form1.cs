using System.Text;

namespace MECH_368_labOne_e3
{
    public partial class QueueTest : Form
    {
        //I do not know what this does. Microsoft docs continue to suck for new users.
        //presumably it's calling a new function (queue), allocating a 32-bit space for storage, and then naming a new instance of that storage 'dataQueue'. 
        public Queue<Int32> dataQueue = new Queue<Int32>();

        //create a function to display items within a queue
        public void UpdateQueue(Queue<Int32> dataQueue, bool displayElements)
        {
            //function UpdateQueue accepts arguments of the name of the queue you would like analyzed & either true/false as options; if true, return is a string of contents of the queue, if false, return is the number of elements in the queue
            //uses a lambda expression - these are something I don't understand as well as I should in order to use, and need to do more research on
            //2023-09-09 - future iterations should be more flexible in the queues that can be input for analysis; hardcoding is the act of a coward (but this is the wrong way to use a queue anyways
            textBoxQueueContents.BeginInvoke((Action)(() =>
            {
                //check to see if a change is needed for contents, use AppendText method if new items as stipulated in Lab (feels like a weird choice, but I might have missed something)
                //could be more efficient with number of items count clear/append
                if (displayElements)
                {
                    StringBuilder contents = new StringBuilder();
                    foreach (int item in dataQueue)
                    {
                        contents.Append(item.ToString());
                        if (item != dataQueue.Last())
                        {
                            contents.Append(", ");
                        }
                        else
                        {
                            contents.Append(Environment.NewLine);
                        }
                    }
                    string result = contents.ToString();
                    if (textBoxQueueContents.Text != result)
                    {
                        textBoxQueueContents.Clear();
                        textBoxQueueContents.AppendText(contents.ToString());
                    }
                }
                else
                {
                    textBoxQueuedItems.Clear();
                    textBoxQueuedItems.AppendText(Convert.ToString(dataQueue.Count));
                }
            }));
        }
        public QueueTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start timer, set tick to conduct an event
            System.Windows.Forms.Timer queueTimer = new System.Windows.Forms.Timer();
            queueTimer.Interval = 100;
            queueTimer.Tick += new EventHandler(queueTimer_Tick);
            queueTimer.Start();
        }
        private void queueTimer_Tick(object sender, EventArgs e)
        {
            UpdateQueue(dataQueue, true);
            UpdateQueue(dataQueue, false);
        }

        private void textBoxEnqueue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //control types of input in textboxEnqueue, allowing only integers
            //2023-09-09 - this seems like an intuitive sanitation, but may not be allowed or expected in this lab - check to see
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            //check whether the text box has anything to add to the queue, add if yes & not too powerful
            if (textBoxEnqueue.Text == "")
            {
                MessageBox.Show("There is nothing to submit to the queue!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //this section should conduct another sanitation for max values, but isn't working. It's a side project of a bug.
                if (Convert.ToInt32(textBoxEnqueue.Text) < Int32.MaxValue)
                {
                    dataQueue.Enqueue(Convert.ToInt32(textBoxEnqueue.Text));
                    textBoxEnqueue.Clear();
                }
                else
                {
                    MessageBox.Show("Your data are too powerful, friend!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            //check whether the queue has numbers to remove from the queue, remove if yes
            if (dataQueue.Count() > 0)
            {
                dataQueue.Dequeue();
            }
            else
            {
                MessageBox.Show("The queue is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDequeueAverage_Click(object sender, EventArgs e)
        {
            //check if there's enough data in the queue to conduct averaging on
            if (Convert.ToInt32(textBoxN.Text) > dataQueue.Count)
            {
                MessageBox.Show("There is not enough data to average!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //find how many points need to be dequeued
                int n = Convert.ToInt32(textBoxN.Text);

                //use a for loop to dequeue and sum - decimal precision
                decimal sum = 0;
                for (int i = 0; i < n; i++)
                {
                    int value = dataQueue.Dequeue();
                    sum += value;
                }

                //take the average, display it in the appropriate box
                decimal average = sum / n;
                textBoxAverage.Text = average.ToString();
            }
        }
    }
}