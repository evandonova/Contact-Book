namespace Contact_Book.Data
{
    public class DataConstants
    {
        public const int MaxFirstNameLength = 15;
        public const int MinFirstNameLength = 2;

        public const int MaxLastNameLength = 20;
        public const int MinLastNameLength = 3;

        public const int MaxEmailLength = 64;

        public const int MaxPhoneNumberLength = 13;

        public const int MaxCommentsLength = 200;

        public const string PhoneNumberRegex = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
    }
}
