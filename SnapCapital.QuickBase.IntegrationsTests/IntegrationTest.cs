using Intuit.QuickBase.Client;
using NUnit.Framework;

namespace SnapCapital.QuickBase.IntegrationsTests
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void TestMethod1()
        {
            var client = Intuit.QuickBase.Client.QuickBase.Login("uri.goldstein@gmail.com", "Kwyjibo69", "snapcredit.quickbase.com");
            var app = client.Connect("bmkhmqry9");
            var table = app.GetTable("bmkhmqrzs");

        }
    }
}
