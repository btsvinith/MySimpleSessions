namespace Utility
{
    public class AgeCalculator
    {
        //TODO: Explain about default parameter.
        internal int Age(DateTime dob, DateTime? currentDate = null)
        {
            return CalculateAge(dob, currentDate);
        }

        protected int GetAgeProtected(DateTime dob, DateTime? currentDate = null)
        {
            return CalculateAge(dob, currentDate);
        }

        protected internal int GetAgeProtectedInternal(DateTime dob, DateTime? currentDate = null)
        {
            return CalculateAge(dob, currentDate);
        }

        private int CalculateAge(DateTime dob, DateTime? currentDate = null)
        {
            DateTime toDate = currentDate ?? DateTime.Now;

            int dobYear = dob.Year;
            int dobMonth = dob.Month;
            int dobDay = dob.Day;

            int toDateYear = toDate.Year;
            int toMonth = toDate.Month;
            int toDay = toDate.Day;

            int age = toDateYear - dobYear;
            if (toMonth < dobMonth)
            {
                age = age - 1;
            }
            if (toMonth == dobMonth && toDay > dobDay)
            {
                age = age - 1;
            }
            return age;
        }

        public int GetAge(DateTime dob, DateTime? currentDate = null)
        {
            return CalculateAge(dob, currentDate);
        }

    }
}