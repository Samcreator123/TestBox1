using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleTestBox.IQueryableAndIEnumerable
{
    [Table("EMPLOYEES")]
    public class EMPLOYEE
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public decimal AGE { get; set; }
        public decimal HEIGHT { get; set; }
        public decimal WEIGHT { get; set; }

        public EMPLOYEE()
        {
        }

        public EMPLOYEE(string ID, string NAME, decimal AGE, decimal HEIGHT, decimal WEIGHT)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.AGE = AGE;
            this.HEIGHT = HEIGHT;
            this.WEIGHT = WEIGHT;
        }
    }
}
