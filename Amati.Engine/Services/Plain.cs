namespace Amati.Engine.Services;

public record Plain(int Id, string Mark, string Number, string Name);


public record User(int Id, string Login, string Name);

public record Some(int Id, string SomeField, string Name);