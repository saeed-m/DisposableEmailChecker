namespace DisposableEmailChecker
{
    /// <summary>
    /// Represents the result of checking an email address.
    /// </summary>
    public enum EmailCheckResult
    {
        /// <summary>Email input is empty or null.</summary>
        IsEmpty,

        /// <summary>Email format is invalid.</summary>
        InvalidFormat,

        /// <summary>Email is valid but uses a known disposable domain.</summary>
        IsDisposable,

        /// <summary>Email is valid and not disposable.</summary>
        IsValid
    }
}
