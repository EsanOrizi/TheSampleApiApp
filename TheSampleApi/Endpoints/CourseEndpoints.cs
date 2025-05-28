using System.Reflection.Metadata.Ecma335;
using TheSampleApi.Data;

namespace TheSampleApi.Endpoints
{
    public static class CourseEndpoints
    {
        public static void AddCourseEndpoints(this WebApplication app)
        {
            app.MapGet("/courses", LoadAllCourses);
            app.MapGet("/courses/{id}", LoadCourseById);
        }

        private static IResult LoadAllCourses(CourseData data)
        {
            return Results.Ok(data.Courses);
        }

        private static IResult LoadCourseById(CourseData data, int id)
        {
            return Results.Ok(data.Courses.SingleOrDefault(x => x.Id == id));
        }
    }



}

    
