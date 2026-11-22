# Trabajo Práctico – Programación 1
## Juego asignado: Pokémon
**Número de grupo: Grupo 3**

## 1. Integrantes del equipo
Completar con los datos reales antes de entregar:
- Apellido y Nombre 1 – Legajo XXXXX – Rol / Rama: `dev-Nombre1Apellido1-Legajo`
- Apellido y Nombre 2 – Legajo XXXXX – Rol / Rama: `dev-Nombre2Apellido2-Legajo`
- Apellido y Nombre 3 – Legajo XXXXX – Rol / Rama: `dev-Nombre3Apellido3-Legajo`

## 2. Diagnóstico y arquitectura inicial
Se modela una parte del universo Pokémon con programación orientada a objetos. La clase base `Pokemon` contiene los datos y comportamientos comunes. Las clases `PokemonFuego` y `PokemonAgua` heredan de ella y redefinen el método virtual `Atacar()`.

La clase `InventarioPokemon` administra una colección de Pokémon. En `Main()` se crean objetos de las clases derivadas, se guardan como tipo `Pokemon` y se recorren para demostrar el polimorfismo: cada objeto ejecuta su propia versión de `Atacar()`.

### Esquema de clases
```text
                 Pokemon
               /         \
      PokemonFuego       PokemonAgua

          InventarioPokemon
          (lista de Pokemon)
```

## 3. Módulos y clases implementadas
- **Clase base: `Pokemon`**. Atributos protegidos (`nombre`, `nivel`, `energia`), constructor validado y método virtual `Atacar()`.
- **Clase derivada 1: `PokemonFuego`**. Hereda de `Pokemon` y sobrescribe `Atacar()` con un ataque de fuego.
- **Clase derivada 2: `PokemonAgua`**. Hereda de `Pokemon` y sobrescribe `Atacar()` con un ataque de agua.
- **Clase gestora: `InventarioPokemon`**. Encapsula una lista de Pokémon y permite agregar y mostrar objetos.

## 4. Control de errores y validaciones
Se impide crear Pokémon con nombre vacío, nivel fuera del rango 1–100 o energía fuera del rango 0–100. También se impide agregar un Pokémon nulo al inventario. Los atributos son protegidos y se consultan mediante propiedades de solo lectura; el constructor valida los datos antes de crear cada objeto.

## 5. Guía de ejecución en consola
1. Instalar el SDK de .NET 8.
2. Abrir una terminal dentro de la carpeta `PokemonGrupo3`.
3. Ejecutar `dotnet run`.
4. El programa crea a Charizard y Blastoise, los agrega al inventario y muestra sus datos y ataques.
5. Para verificar el polimorfismo, observar que ambos se manejan como `Pokemon`, pero cada uno ejecuta un ataque diferente.

## Archivos
- `PokemonGrupo3.csproj`: configuración del proyecto de consola.
- `Program.cs`: clases y método `Main()`.

Este proyecto es una actividad educativa inspirada en Pokémon. No es oficial ni está afiliado a Game Freak, Nintendo o The Pokémon Company.
