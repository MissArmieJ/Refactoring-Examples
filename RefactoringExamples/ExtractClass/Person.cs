namespace RefactoringExamples.ExtractClass
{
    public class Person
    {
        private readonly string _name;
        private readonly TelephoneNumber _officeTelephoneNumber;

        public Person(string name, string officeAreaCode, string officeNumber)
        {
            _name = name;
            _officeTelephoneNumber = new TelephoneNumber(officeAreaCode, officeNumber);
        }

        public string GetName()
        {
            return _name;
        }

        public string GetOfficeTelephoneNumber()
        {
            return "(" + _officeTelephoneNumber.GetAreaCode() + ") " + _officeTelephoneNumber.GetNumber();
        }
    }
}