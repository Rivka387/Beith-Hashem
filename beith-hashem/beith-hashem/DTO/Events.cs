namespace beith_hashem.DTO
{
    /*פעילות חברתית
1.	מזהה להפקה
2.	שם הפקה
3.	תאריך 
4.	משך זמן – אורך פעילות
5.	מקום הפעילות
6.	קהל היעד נשים /בחורי ישיבה/ילדות וכו'
7.	מספר כרטיסים מקסימלי של קהל
8.	עלות כניסה

*/

    public enum TargetAudience { girls = 1, boys = 2, children = 4, YeshivaGdolaGuys = 8, YeshivaKtanaGuy = 16, SeminarGirls = 32, women = 64, men = 128 }
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public string place { get; set; }

        public int MaxCardsAmount { get; set; }
        public double price { get; set; }




    }
}
