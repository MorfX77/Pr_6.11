using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PR_6
{
    class ToyFactory
    {
        private static ToyFactory instance;
        private List<string> toys = new List<string> { "Слон", "Кукла", "Машинка" };
        private Random rnd = new Random();
        private TextBox textBox_Toys;
        private ToyFactory() { }

        public ToyFactory(TextBox textBox_Toys)
        {
            this.textBox_Toys = textBox_Toys;
        }
        public static ToyFactory GetInstance()
        {
            if (instance == null)
                instance = new ToyFactory();
            return instance;
        }
        public string CreateToy()
        {
            int rndIndex = rnd.Next(toys.Count);
            return toys[rndIndex];
        }
        public void SimulateRandomEvent()
        {
                int eventcode = rnd.Next(3);
                if (eventcode == 0) { MessageBox.Show("Сломалась лента на производственной линии!"); }
                else if (eventcode == 1) { MessageBox.Show("Пришел заказ на эксклюзивную игрушку!"); }
                else { MessageBox.Show("Новый сотрудник начал работу на фабрике!"); }
        }

        public string ProduceToys()
        {
            while (true)
            {
                    int rndEvent = rnd.Next(4);
                    if (rndEvent == 0) { return textBox_Toys.Text = "Фабрика производит игрушки"; }
                    else if (rndEvent == 1) { return textBox_Toys.Text = "Необходимо заменить сломанное оборудование"; }
                    else if (rndEvent == 2) { return textBox_Toys.Text = "Повышен спрос на игрушки"; }
                    else { return textBox_Toys.Text = "Фабрика работает стабильно."; }
            }
        }
    }
}
