# courses-assignment

This a standard AspNetCore application so running it should not be a problem.

Remarks:
The apply for the course method has a relative address:
/api/courses/{courseid}/apply

For example:
/api/courses/9d401e07-3018-4aef-a62e-ca0ec308e59e/apply

The courseid is a Guid and this is a POST method requiring something like this in the body:
{
	"UserId": "456c5e31-b593-4076-aa24-0423a9d63438"
}

# Exposed methods

The data is currently persisted only in memory, but to find the data without looking through the code 
several methods were also exposed:

[GET]
/api/users -> to find all the users and their Guid Ids

[GET]
/api/courses -> to find all the courses and their Guid Ids

[GET]
/api/courses/{courseid}/getapplied -> allows us to check which users have applied for the course

For example:

/api/courses/9d401e07-3018-4aef-a62e-ca0ec308e59e/getapplied
