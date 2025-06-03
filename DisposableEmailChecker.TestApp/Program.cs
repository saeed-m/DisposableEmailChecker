using DisposableEmailChecker;

while (true)
{
    Console.WriteLine("Enter an email to check (or type 'exit' to quit):");
    string? input = Console.ReadLine();

    if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
        break;

    if (input != null)
    {
        var result = DisposableEmailDomains.CheckEmail(input);

        switch (result)
        {
            case EmailCheckResult.IsEmpty:
                Console.WriteLine("⚠️ Email is empty.");
                break;
            case EmailCheckResult.InvalidFormat:
                Console.WriteLine("❌ Invalid email format.");
                break;
            case EmailCheckResult.IsDisposable:
                Console.WriteLine("⚠️ IsDisposable email detected.");
                break;
            case EmailCheckResult.IsValid:
                Console.WriteLine("✅ Email is valid and not disposable.");
                break;
        }
    }

    Console.WriteLine(); // Add a blank line for readability
}