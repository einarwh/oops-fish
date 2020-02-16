using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    internal class FishPicture : FigurePicture
    {
        public FishPicture() : base(Shapes) {}

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

                var rightFinPath = new PathShape(
                    new Point(0.234, 0.798),
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(0.340, 0.792), 
                            new Point(0.411, 0.783), 
                            new Point(0.500, 0.750)),
                        new BezierCurveSegment(
                            new Point(0.500, 0.625),
                            new Point(0.500, 0.575),
                            new Point(0.500, 0.500)),
                        new BezierCurveSegment(
                            new Point(0.460, 0.460),
                            new Point(0.410, 0.410),
                            new Point(0.377, 0.377))
                    });

                var spinePath = new PathShape(
                    new Point(0.116, 0.702),
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(0.260, 0.295),
                            new Point(0.330, 0.258),
                            new Point(0.815, 0.078))
                    });

                var leftEyePath = new PathShape(
                    new Point(0.053,0.658),
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(0.075, 0.677),
                            new Point(0.085,0.687),
                            new Point(0.098,0.700)),
                        new BezierCurveSegment(
                            new Point(0.092, 0.752),
                            new Point(0.085, 0.812),
                            new Point(0.053, 0.819)),
                        new BezierCurveSegment(
                            new Point(0.042, 0.760),
                            new Point(0.042, 0.710),
                            new Point(0.053, 0.658))
                    });

                var rightEyePath = new PathShape(
                    new Point(0.187, 0.752),
                    new List<BezierCurveSegment>
                    {
                        new BezierCurveSegment(
                            new Point(0.175, 0.745),
                            new Point(0.150, 0.730),
                            new Point(0.130,0.718)),
                        new BezierCurveSegment(
                            new Point(0.110, 0.795),
                            new Point(0.110, 0.810),
                            new Point(0.112, 0.845)),
                        new BezierCurveSegment(
                            new Point(0.150, 0.805),
                            new Point(0.172, 0.780),
                            new Point(0.187, 0.752))
                    });

                var leftFinPath1 = new PathShape(
                    new Point(-0.170, 0.237),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(-0.125, 0.355),
                            new Point(-0.065, 0.405),
                            new Point(0.002, 0.436))
                    });

                var leftFinPath2 = new PathShape(
                    new Point(-0.121, 0.188),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(-0.060, 0.300),
                            new Point(-0.030, 0.330),
                            new Point(0.040, 0.375))
                    });

                var leftFinPath3 = new PathShape(
                    new Point(-0.058, 0.125),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(-0.010, 0.240),
                            new Point(0.030, 0.280),
                            new Point(0.100, 0.321))
                    });

                var leftFinPath4 = new PathShape(
                    new Point(-0.022, 0.063),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.060, 0.200),
                            new Point(0.100, 0.240),
                            new Point(0.160, 0.282))
                    });

                var rightFinPath1 = new PathShape(
                    new Point(0.315, 0.710),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.378, 0.732),
                            new Point(0.426, 0.726),
                            new Point(0.487, 0.692))
                    });

                var rightFinPath2 = new PathShape(
                    new Point(0.340, 0.605),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.400, 0.642),
                            new Point(0.435, 0.647),
                            new Point(0.489, 0.626))
                    });

                var rightFinPath3 = new PathShape(
                    new Point(0.348, 0.502),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.400, 0.564),
                            new Point(0.422, 0.568),
                            new Point(0.489, 0.563))
                    });

                var rightFinShadowPath1 = new PathShape(
                    new Point(0.451, 0.418),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.465, 0.400),
                            new Point(0.480, 0.385),
                            new Point(0.490, 0.381))
                    });

                var rightFinShadowPath2 = new PathShape(
                    new Point(0.421, 0.388),
                    new[]
                    {
                        new BezierCurveSegment(
                            new Point(0.440, 0.350),
                            new Point(0.455, 0.335),
                            new Point(0.492, 0.325))
                    });

                var list = new List<IShape>
                {
                    bodyPath,
                    leftFinPath,
                    rightFinPath,
                    spinePath,
                    leftEyePath,
                    rightEyePath,
                    leftFinPath1,
                    leftFinPath2,
                    leftFinPath3,
                    leftFinPath4,
                    rightFinPath1,
                    rightFinPath2,
                    rightFinPath3,
                    rightFinShadowPath1,
                    rightFinShadowPath2
                };

                return list;
            }
        }

    }
}