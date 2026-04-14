<h1 align="center">⭐ FLAdmin ⭐</h1>

<p align="center">
  <b>Administrative panel for managing Freelancer / FLHook server infrastructure</b>
</p>

<p align="center">
  <img src="https://shields.dvurechensky.pro/badge/Status-Abandoned-orange?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/Stage-Prototype-blue?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/.NET-Backend-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/MongoDB-Database-47A248?style=for-the-badge&logo=mongodb&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/RabbitMQ-Queue-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white" />
  <img src="https://shields.dvurechensky.pro/badge/Message%20Bus-Event%20Driven-6A1B9A?style=for-the-badge" />
  <img src="https://shields.dvurechensky.pro/badge/License-Private-lightgrey?style=for-the-badge" />
</p>

<div align="center" style="margin: 20px 0; padding: 10px; background: #1c1917; border-radius: 10px;">
  <strong>🌐 Language: </strong>
  
  <a href="./README.ru.md" style="color: #F5F752; margin: 0 10px;">
    🇷🇺 Russian
  </a>
  | 
  <span style="color: #0891b2; margin: 0 10px;">
    ✅ 🇺🇸 English (current)
  </span>
</div>

---

> [!NOTE]
> This project is part of the **Lizerium** ecosystem and belongs to the following direction:
>
> - [`Lizerium.Software.Structs`](https://github.com/Lizerium/Lizerium.Software.Structs)
>
> If you are looking for related engineering and supporting tools, start there.

---

## 📌 About the Project

**FLAdmin** is a prototype of an administrative panel designed as a centralized tool for managing and interacting with server infrastructure, services, and internal modules related to **Freelancer / FLHook** projects.

At the moment, the project is **not completed** and is in a **frozen / abandoned state**, but it contains architectural groundwork and environment setup instructions.

> [!WARNING]
> This project is in **prototype / abandoned** state.  
> Some parts may be incomplete, outdated, or require manual configuration.

---

## ✨ Idea

Project goals:

- centralize administration of system components
- use **message queues** for inter-module communication
- store and process data via **MongoDB**
- simplify internal server operations and extensibility

---

## 🧱 Tech Stack

- **Windows**
- **MongoDB**
- **RabbitMQ**
- **Erlang/OTP**
- **.NET backend**
- Internal services / administrative logic

---

## 🚀 Quick Start

### 1) Install dependencies

#### Via PowerShell

```powershell
winget install --id MongoDB.Shell
```

#### Manual installation

- `mongodb-windows-x86_64-8.0.10-signed.exe`
- `otp_win64_28.0.exe`
- `rabbitmq-server-4.1.1.exe`

---

## 🗄 MongoDB

### Credentials

```ini
Login: quest
Password: <your password>
```

### Connection string

```ini
mongodb://localhost:27017/
```

### Run shell

```powershell
mongosh
```

---

## 🐇 RabbitMQ

### Default credentials

```ini
Login: guest
Password: guest
Host: localhost
Port: 5672
```

### Web UI

```text
http://localhost:15672/
```

### Installation path

```text
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.1.1\sbin
```

---

## ⚙ RabbitMQ Configuration

### Get computer name

```powershell
hostname
```

### Set RabbitMQ node name

> Run in:

```text
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.1.1\sbin
```

```powershell
set RABBITMQ_NODENAME=rabbit@DESKTOP-5UOIHDN
```

> [!NOTE]
> Replace `DESKTOP-5UOIHDN` with your actual machine name.

---

## 🖥 Enable RabbitMQ Web UI

```powershell
.\rabbitmq-plugins.bat enable rabbitmq_management
```

### Check plugins

```powershell
.\rabbitmq-plugins.bat list
```

---

## 🛠 Manage RabbitMQ as a Windows Service

### Stop

```powershell
net stop RabbitMQ
```

### Start

```powershell
net start RabbitMQ
```

### Check status

```powershell
Get-Service rabbitmq
```

---

## 📂 Current Project State

At the moment, the repository contains:

- parts of server infrastructure
- initial admin panel groundwork
- environment setup instructions
- foundation for future development

---

## 📉 Status

> One day I’ll finish this.

For now, it is:

- an **archived idea**
- a **working skeleton**
- a **technical draft**
- a **future revival candidate**

---

## 🧠 Notes

This repository can be useful as:

- a foundation for a future admin panel
- a base for service-oriented architecture
- a prototype for server-side tooling in FLHook / Freelancer environments
