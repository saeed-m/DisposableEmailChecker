# DisposableEmailChecker

A lightweight .NET 9 library to detect disposable (temporary) email addresses using a built-in list of known domains.

---

## 🔧 Installation

Install via NuGet:

```bash
dotnet add package DisposableEmailChecker



## Usage

```csharp
using DisposableEmailChecker;

Console.WriteLine("Enter an email to check:");
string? input = Console.ReadLine();
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
        Console.WriteLine("⚠️ Disposable email detected.");
        break;
    case EmailCheckResult.IsValid:
        Console.WriteLine("✅ Email is valid and not disposable.");
        break;
}
