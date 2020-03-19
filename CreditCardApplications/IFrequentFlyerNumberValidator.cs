using System;

namespace CreditCardApplications
{
    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);

        IServiceInformation serviceInformation { get; }

    }

    public interface ILicenseData
    {
        string LicenseKey { get;  }

    }

    public interface IServiceInformation
    {
        ILicenseData License { get; set; }

    }
}