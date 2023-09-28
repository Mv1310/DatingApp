namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            var dobdate = DateOnly.FromDateTime(dob);
            var age = today.Year - dobdate.Year;
            if(dobdate > today.AddYears(-age)) age--;
            return age;
        }
    }
}