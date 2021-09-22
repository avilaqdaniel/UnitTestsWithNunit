# Test unitarios con Nunit

Crear solución para proyectos
```dotnet new sln -n UnitTestsWithNunit```

Crear proyecto "Librería de clases"
```dotnet new classlib -n MyProject```

Añadir proyecto a la solución creada
```dotnet sln add MyProject/MyProject.csproj```

Crear proyecto Nunit
```dotnet new nunit -n MyProjectTests```

Añadir proyecto Nunit a la solución
```dotnet sln add MyProjectTests/MyProjectTests.csproj```

Añadir referencia al proyecto a testear
```dotnet add reference ../MyProject/MyProject.csproj```

Ejecutar test
```dotnet test```