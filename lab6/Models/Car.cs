using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Car
    {

        private long id;
        private string model;
        private int price;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
