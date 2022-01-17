using System;
using Xunit;
using metrics.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace metricsTests
{
    public class metricsAgentsTests
    {
        CpuMetricsController controller = new();

        [Fact]
        public void GetCpuMetrics_ReturnsOk() {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetCpuMetrics(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
