using TriangleSample;
using Xunit;

namespace TestProject1
{
    public class NodesCoverage
    {
        [Fact]
        public void test1() {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.Equal("Разносторонний", testTr.TypeOfTriangle(testArr));
        }
    }
}