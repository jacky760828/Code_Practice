namespace inter_face
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creature creature = new village();
            I_Attack_able Someone = new Monster();
            Someone.attack(creature);


            MessageBox.Show(creature.say());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creature creature = new village();
            I_Talk someone= new player();
            MessageBox.Show(someone.TalkTo(creature));
        }
    }
}
