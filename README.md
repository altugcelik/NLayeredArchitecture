# NLayeredArchitecture
N-Layered Architecture


With this architecture:

# API layer owns:
Request models
Response models
Controller
Mapping to/from DTOs

# Business layer owns:
DTOs
Interfaces
Service implementations

# Data Access layer owns:
Repositories
Entities

# Layers do NOT leak data models between each other.
This is exactly how clean enterprise C# APIs are built.