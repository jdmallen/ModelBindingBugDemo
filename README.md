# model-binding-bug-demo
Demonstration of an [ASP.NET Core MVC model binding bug](https://github.com/aspnet/Mvc/issues/7357).

### How to test

Run the project and execute the following HTTP command in Postman, Chrome, Fiddler, etc:

```json
POST /api/test HTTP/1.1
Host: localhost:26730
Content-Type: application/json
Cache-Control: no-cache

{
	"User": {
		"UserSid": "S-1-5-21-1004336348-1177238915-682003330-512"
	}
}
```
