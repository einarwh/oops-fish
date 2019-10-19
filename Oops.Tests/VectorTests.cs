using Xunit;

namespace Oops.Tests
{
    public class VectorTests
    {
        [Fact]
        public void Vector_ValueEquality()
        {
            var v1 = new Vector(3, 7);
            var v2 = new Vector(3, 7);
            Assert.Equal(v1, v2);
        }

        [Fact]
        public void AddVectors_AddingNullVector()
        {
            var v = new Vector(1, 2);
            Assert.Equal(v, v + new Vector(0, 0));
            Assert.Equal(v, new Vector(0, 0) + v);
        }

        [Fact]
        public void AddVectors_VectorsThatAddUpToNullVector()
        {
            var v1 = new Vector(1, 2);
            var v2 = new Vector(-1, -2);
            Assert.Equal(new Vector(0, 0), v1 + v2);
        }

        [Fact]
        public void AddVectors_AddingVectorToItselfDoublesIt()
        {
            var v = new Vector(1, 2);
            Assert.Equal(new Vector(2, 4), v + v);
        }

        [Fact]
        public void NegateVector_Example1()
        {
            var v = new Vector(1, 2);
            Assert.Equal(new Vector(-1, -2), -v);
        }

        [Fact]
        public void NegateVector_Example2()
        {
            var v = new Vector(3, 3);
            Assert.Equal(new Vector(-3, -3), -v);
        }

        [Fact]
        public void NegateVector_NullVector()
        {
            var v = new Vector(0, 0);
            Assert.Equal(v, -v);
        }


        [Fact]
        public void SubtractVectors_SubtractingNullVector()
        {
            var nv = new Vector(0, 0);
            var v = new Vector(1, 3);
            Assert.Equal(v, v - nv);
        }

        [Fact]
        public void SubtractVectors_SubtractingVectorFromItselfYieldsNullVector()
        {
            var nv = new Vector(0, 0);
            var v = new Vector(1, 3);
            Assert.Equal(new Vector(0, 0), v - v);
        }

        [Fact]
        public void SubtractVectors_Example()
        {
            var v1 = new Vector(3, 5);
            var v2 = new Vector(1, 1);
            Assert.Equal(new Vector(2, 4), v1 - v2);
            Assert.Equal(new Vector(-2, -4), v2 - v1);
        }
    }
}
