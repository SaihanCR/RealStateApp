# 🏠 RealEstateApp

**RealEstateApp** es una aplicación web para la gestión de propiedades inmobiliarias desarrollada con **ASP.NET Core MVC** y arquitectura **Onion**, orientada a clientes, agentes y administradores. La solución incluye además una **API REST segura con JWT** y funcionalidades completas para administración, mantenimiento y visualización de propiedades.

---

## 🚀 Tecnologías utilizadas

- ASP.NET Core MVC 6/7/8
- Entity Framework Core (Code First)
- Identity (autenticación/autorización)
- AutoMapper
- JWT (para autenticación en API)
- Swagger (documentación de API)
- FluentValidation + CQRS + Mediator
- Bootstrap (frontend)

---

## 🎯 Objetivo

Desarrollar una plataforma web y API para el manejo completo de propiedades inmobiliarias, ofreciendo funcionalidades personalizadas por rol: cliente, agente, administrador y desarrollador (API).

---

## 👤 Roles y funcionalidades

### 🧑 Cliente
- Ver y filtrar propiedades disponibles
- Marcar propiedades favoritas
- Chatear con agentes
- Realizar y gestionar ofertas

### 🧑‍💼 Agente
- Gestionar sus propiedades (crear, editar, eliminar)
- Ver y responder ofertas
- Chatear con clientes
- Editar su perfil

### 👨‍💼 Administrador
- Gestión de usuarios (agentes, desarrolladores, administradores)
- Mantenimiento de tipos de propiedades, ventas y mejoras
- Indicadores de uso (propiedades, usuarios activos/inactivos)

### 🔧 API para desarrolladores
- Autenticación con JWT
- CRUD de propiedades, agentes, tipos y mejoras
- Restricciones por roles (Admin vs. Desarrollador)

---

## 📦 Estructura del proyecto

- `WebApp/` - Interfaz principal para cliente, agente y administrador
- `API/` - Web API con controladores seguros
- `Application/` - Lógica de negocio, servicios y CQRS
- `Domain/` - Entidades del dominio
- `Infrastructure/` - Acceso a datos, configuración de seguridad y servicios
- `Shared/` - Modelos compartidos, ViewModels y DTOs

---

## 🔐 Seguridad

- Control de acceso por rol con `[Authorize]`
- Protección de API con tokens JWT
- Acceso restringido según el tipo de usuario
- Manejo de sesiones y redirección por permisos

---

## 📄 Documentación de la API

Disponible en Swagger una vez ejecutada la aplicación API:
