namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }

        public Pizza(int id,string Nome, string Descizione, double Prezzo, string Foto)
        {
            this.Id = id;
            this.Name = Nome;
            this.Description = Descizione;
            this.Price = Prezzo;
            this.Photo = Foto;
        }

        public Pizza()
        { }
    }


}
