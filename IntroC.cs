

    var sale = new SaleWithTax(15, 1.16m);
    var mensaje = sale.GetInfo();

    Console.WriteLine(mensaje);
    

class SaleWithTax : Sale
    {
        public decimal Tax { get; set; }

        public SaleWithTax(decimal total, decimal tax) : base(total)
        {
            Tax = tax;
        }

        public override string GetInfoWithTax()
        {
            return "El total es " + Total + "Impuesto es: " + Tax;

        }
        public string GetInfo(string mensaje)
        {
            return ,mensaje;
        }
    }



    class Sale
    {
        public decimal Total { get; set; }
        private decimal _some;

        public Sale(decimal total)
        {
            Total = total;
            _some = 8;
        }

        public virtual string GetInfo()
        {
            return "El total es " + Total;
        }
    }
