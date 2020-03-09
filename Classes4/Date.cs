namespace Classes4
{
    public class Date
    {
        private int _month = 7;
        public int month {
            get => _month;
            set 
            {
                if((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }

        string monthString;

        public string ConvertMoth()
        {
            switch(month)
            {
                case 1:
                    monthString = "January";
                    break;
                case 2:
                    monthString = "February";
                    break;
                case 3:
                    monthString = "March";
                    break;
                case 4:
                    monthString = "May";
                    break;
                case 5:
                    monthString = "June";
                    break;
                case 6:
                    monthString = "July";
                    break;
                case 7:
                    monthString = "August";
                    break;
                case 8:
                    monthString = "September";
                    break;
                case 9:
                    monthString = "October";
                    break;
                case 10:
                    monthString = "November";
                    break;
                default:
                    monthString = "December";
                    break;
            }

            return monthString;
        }

    }
}