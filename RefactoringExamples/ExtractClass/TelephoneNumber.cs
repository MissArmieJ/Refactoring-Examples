namespace RefactoringExamples.ExtractClass
{
    public class TelephoneNumber
    {
        private string _areaCode;
        private string _number;

        public TelephoneNumber(string areaCode, string number)
        {
            _areaCode = areaCode;
            _number = number;
        }

        public void SetAreaCode(string value)
        {
            _areaCode = value;
        }

        public string GetAreaCode()
        {
            return _areaCode;
        }

        public void SetNumber(string value)
        {
            _number = value;
        }

        public string GetNumber()
        {
            return _number;
        }
    }
}