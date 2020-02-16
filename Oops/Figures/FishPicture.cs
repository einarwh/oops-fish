using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    internal class FishPicture : FigurePicture
    {
        public FishPicture() : base(Shapes)
        {
        }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var bodyPath = new PathShape(
                    new Point(1.000, 0),
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(0.834, 0.042),
                            new Point(0.730, 0.056),
                            new Point(0.564, 0.032)),
                        new BezierCurveSegment(
                            new Point(0.452, 0.132),
                            new Point(0.372, 0.194),
                            new Point(0.250, 0.250)),
                        new BezierCurveSegment(
                            new Point(0.080, 0.330),
                            new Point(0.055, 0.355),
                            new Point(-0.032, 0.564)),
                        new BezierCurveSegment(
                            new Point(-0.056, 0.730),
                            new Point(-0.042, 0.834),
                            new Point(0.000, 1.000)),
                        new BezierCurveSegment(
                            new Point(0.104, 0.938),
                            new Point(0.163, 0.893),
                            new Point(0.234, 0.798)),
                        new BezierCurveSegment(
                            new Point(0.368, 0.650),
                            new Point(0.232, 0.540),
                            new Point(0.377, 0.377)),
                        new BezierCurveSegment(
                            new Point(0.400, 0.350),
                            new Point(0.450, 0.300),
                            new Point(0.500, 0.250)),
                        new BezierCurveSegment(
                            new Point(0.589, 0.217),
                            new Point(0.660, 0.208),
                            new Point(0.766, 0.202)),
                        new BezierCurveSegment(
                            new Point(0.837, 0.107),
                            new Point(0.896, 0.062),
                            new Point(1.000, 0.000))
                    });

                var leftFinPath = new PathShape(
                    new Point(-0.032, 0.564), 
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(-0.132, 0.452),
                            new Point(-0.194, 0.372),
                            new Point(-0.250, 0.250)),
                        new BezierCurveSegment(
                            new Point(-0.150, 0.150),
                            new Point(-0.090, 0.090),
                            new Point(0.000, 0.000)),
                        new BezierCurveSegment(
                            new Point(0.110, 0.110),
                            new Point(0.175, 0.175), 
                            new Point(0.250, 0.250))
                    });

                var list = new List<IShape>
                {
                    bodyPath,
                    leftFinPath
                };
                return list;
            }
        }

    }
}