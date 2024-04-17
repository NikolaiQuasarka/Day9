namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            register = new Register();



        }
        Register register;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                RS trigger = new RS();
                trigger.Set(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                register.AddTrigger(trigger);
            }
            else if (radioButton2.Checked)
            {
                JK trigger = new JK();
                trigger.Set(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                register.AddTrigger(trigger);
            }
            Update();
        }

        private void Update()
        {
            dataGridView1.Rows.Clear();
            foreach (Trigger trigger in register.Triggers)
            {
                dataGridView1.Rows.Add(trigger.GetType().Name, trigger.Inputs[0].ToString(), trigger.Inputs[1].ToString(), trigger.Inputs[2].ToString(), trigger.Outputs[0].ToString(), trigger.Outputs[1].ToString());

            }
        }

        private void buttonVivod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string str in register.PrintTriggers())
            {
                listBox1.Items.Add(str);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            register.ResetAll();
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register.SetAll([checkBox4.Checked,checkBox5.Checked,checkBox6.Checked]);
            Update();
        }
    }
}
