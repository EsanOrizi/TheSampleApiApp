using System.Reflection.Metadata.Ecma335;
using TheSampleApi.Data;

namespace TheSampleApi.Endpoints
{
    public static class CourseEndpoints
    {
        public static void AddCourseEndpoints(this WebApplication app)
        {
            app.MapGet("/courses", (CourseData data) =>
            {
                return data.Courses;
            });
        }
    }
}
