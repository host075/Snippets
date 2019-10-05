string test = "{\"message\":8,\"contact\":1}";
project.Json.FromString(test);
return project.Json.message;
