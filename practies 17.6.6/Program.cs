using practies_17._6._6.Profiles;

class Program
{
    static void Main(string[] args)
    {
        Account[] accounts = CreateAcconts();
        foreach(var account in accounts)
        {
            Console.WriteLine(account.Type);
            Console.WriteLine(account.Balance);
            

            ILandingProfile profile = CreateLandingProfile(account.Type);
            profile.CalculateInterest(account);
            
            Console.WriteLine(account.Interest);
        }
        

    }
    static ILandingProfile CreateLandingProfile(AccountType Type)
    {
        switch (Type)
        {
            case AccountType.Payroll:
                return new CalcPayrollClient();

            case AccountType.Ordinary:
                return new CalcOrdinaryClient();

            default: throw new NotImplementedException("Неизвестный тип аккаунта");
        }
    }
    static Account[] CreateAcconts()

    {
        return new Account[]
        {
            new Account(){Type=AccountType.Payroll, Balance=10000},
            new Account(){Type=AccountType.Ordinary, Balance=900}
        };
    }

}
public enum AccountType
{
    Payroll, Ordinary
}
public class Account
{
    // тип учетной записи
    public AccountType Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
}