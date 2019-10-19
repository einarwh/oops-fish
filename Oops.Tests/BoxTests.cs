using Xunit;

namespace Oops.Tests
{
    public class BoxTests
    {
        [Fact]
        public void Box_ValueEquality()
        {
            var box1 = new Box(new Vector(0, 0), new Vector(1, 0), new Vector(0, 1));
            var box2 = new Box(new Vector(0, 0), new Vector(1, 0), new Vector(0, 1));
            Assert.Equal(box1, box2);
        }

        [Fact]
        public void Box_Turn()
        {
            var box = new Box(new Vector(1, 2), new Vector(2, 0), new Vector(0, 3));
            var expected = new Box(new Vector(3, 2), new Vector(0, 3), new Vector(-2, 0));
            Assert.Equal(expected, box.Turn());
        }

        [Fact]
        public void Box_Turn_Four_Times()
        {
            var box = new Box(new Vector(1, 2), new Vector(2, 0), new Vector(0, 3));
            Assert.Equal(box, box.Turn().Turn().Turn().Turn());
        }

        [Fact]
        public void Box_Flip()
        {
            var box = new Box(new Vector(1, 2), new Vector(2, 0), new Vector(0, 3));
            var expected = new Box(new Vector(3, 2), new Vector(-2, 0), new Vector(0, 3));
            Assert.Equal(expected, box.Flip());
        }

        [Fact]
        public void Box_Flip_Twice()
        {
            var box = new Box(new Vector(1, 2), new Vector(2, 0), new Vector(0, 3));
            Assert.Equal(box, box.Flip().Flip());
        }

        [Fact]
        public void Box_Toss()
        {
            var box = new Box(new Vector(1, 2), new Vector(2, 0), new Vector(0, 2));
            var expected = new Box(new Vector(2, 3), new Vector(1, 1), new Vector(-1, 1));
            Assert.Equal(expected, box.Toss());
        }
    }
}
