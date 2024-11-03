namespace beith_hashem.DTO
{
    public enum DavenType { Shacharit, Mincha, Arvit, SpecialDaven}
    public enum Day { Sunday, Monday, Tuesday, Wendsday, Thursday, Friday, Saturday }
    public enum MinyanType { Slow, Fast, InRetrospect }
    public class Davening
    {
        public int Id { get; set; }
        public DavenType Daven{ get; set; }
        public DateOnly DavenTime { get; set; }
        public string Place { get; set; }
        public Day MyProperty { get; set; }
        public int MaxMember { get; set; }
        public MinyanType Type { get; set; }
        public bool IsEzratNashimExists { get; set; }
    }
}
