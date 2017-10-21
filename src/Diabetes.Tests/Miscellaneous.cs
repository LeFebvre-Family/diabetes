using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diabetes.Tests
{
    public class Miscellaneous
    {

        [Fact]
        public void Interactive_Demonstrations()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"int.MinValue = {int.MinValue}");
            builder.AppendLine($"int.MaxValue = {int.MaxValue}");
            builder.AppendLine($"uint.MinValue = {uint.MinValue}");
            builder.AppendLine($"uint.MaxValue = {uint.MaxValue}");
            builder.AppendLine($"ulong.MinValue = {ulong.MinValue}");
            builder.AppendLine($"ulong.MaxValue = {ulong.MaxValue}");
            builder.AppendLine($"single.MinValue = {Single.MinValue}");
            builder.AppendLine($"single.MaxValue = {Single.MaxValue}");
            builder.AppendLine($"double.MinValue = {Double.MinValue}");
            builder.AppendLine($"double.MaxValue = {Double.MaxValue}");
            throw new Exception(builder.ToString());
        }

    }
}
