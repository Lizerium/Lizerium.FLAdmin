<h1 align="center">⭐ FLAdmin ⭐</h1>

<p align="center">
  <b>Административная панель для управления серверной инфраструктурой Freelancer / FLHook-проектов</b>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Status-Abandoned-orange?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Stage-Prototype-blue?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-Backend-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/MongoDB-Database-47A248?style=for-the-badge&logo=mongodb&logoColor=white" />
  <img src="https://img.shields.io/badge/RabbitMQ-Queue-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white" />
  <img src="https://img.shields.io/badge/Message%20Bus-Event%20Driven-6A1B9A?style=for-the-badge" />
  <img src="https://img.shields.io/badge/License-Private-lightgrey?style=for-the-badge" />
</p>

---

## 📌 О проекте

**FLAdmin** — это прототип административной панели, задуманной как централизованный инструмент управления и взаимодействия с серверной инфраструктурой, сервисами и внутренними модулями, связанными с проектами на базе **Freelancer / FLHook**.

На текущий момент проект **не завершён** и находится в состоянии **замороженной / брошенной реализации**, но содержит заготовки архитектуры и инструкции для развёртывания окружения.

> [!WARNING]
> Проект находится в состоянии **prototype / abandoned**.  
> Некоторые части могут быть недоделаны, неактуальны или требовать ручной настройки.

- [📌 О проекте](#-о-проекте)
- [✨ Идея](#-идея)
- [🧱 Используемый стек](#-используемый-стек)
- [🚀 Быстрый старт](#-быстрый-старт)
  - [1) Установить зависимости](#1-установить-зависимости)
    - [Через PowerShell](#через-powershell)
    - [Установить вручную](#установить-вручную)
- [🗄 MongoDB](#-mongodb)
  - [Доступы](#доступы)
  - [Адрес подключения](#адрес-подключения)
  - [Запуск shell](#запуск-shell)
- [🐇 RabbitMQ](#-rabbitmq)
  - [Доступы по умолчанию](#доступы-по-умолчанию)
  - [Web UI](#web-ui)
  - [Путь установки сервера](#путь-установки-сервера)
- [⚙ Настройка RabbitMQ](#-настройка-rabbitmq)
  - [Узнать имя компьютера](#узнать-имя-компьютера)
  - [Установить имя ноды RabbitMQ](#установить-имя-ноды-rabbitmq)
- [🖥 Включение web-интерфейса RabbitMQ](#-включение-web-интерфейса-rabbitmq)
  - [Проверить список плагинов](#проверить-список-плагинов)
- [🛠 Управление RabbitMQ как сервисом Windows](#-управление-rabbitmq-как-сервисом-windows)
  - [Остановить](#остановить)
  - [Запустить](#запустить)
  - [Проверить статус](#проверить-статус)
- [📂 Текущее состояние проекта](#-текущее-состояние-проекта)
- [📉 Статус](#-статус)
- [🧠 Примечание](#-примечание)

---

## ✨ Идея

Цель проекта:

- централизовать администрирование компонентов;
- использовать **очереди сообщений** для взаимодействия между модулями;
- хранить и обрабатывать данные через **MongoDB**;
- упростить внутреннюю серверную эксплуатацию и расширяемость.

---

## 🧱 Используемый стек

- **Windows**
- **MongoDB**
- **RabbitMQ**
- **Erlang/OTP**
- **.NET backend**
- Внутренние сервисы / административная логика

---

## 🚀 Быстрый старт

### 1) Установить зависимости

#### Через PowerShell

```powershell
winget install --id MongoDB.Shell
```

#### Установить вручную

- `mongodb-windows-x86_64-8.0.10-signed.exe`
- `otp_win64_28.0.exe`
- `rabbitmq-server-4.1.1.exe`

---

## 🗄 MongoDB

### Доступы

```ini
Login: quest
Password: <ваш пароль>
```

### Адрес подключения

```ini
mongodb://localhost:27017/
```

### Запуск shell

```powershell
mongosh
```

---

## 🐇 RabbitMQ

### Доступы по умолчанию

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

### Путь установки сервера

```text
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.1.1\sbin
```

---

## ⚙ Настройка RabbitMQ

### Узнать имя компьютера

```powershell
hostname
```

### Установить имя ноды RabbitMQ

> Выполнять в директории:

```text
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.1.1\sbin
```

```powershell
set RABBITMQ_NODENAME=rabbit@DESKTOP-5UOIHDN
```

> [!NOTE]
> Вместо `DESKTOP-5UOIHDN` подставь своё имя компьютера.

---

## 🖥 Включение web-интерфейса RabbitMQ

```powershell
.\rabbitmq-plugins.bat enable rabbitmq_management
```

### Проверить список плагинов

```powershell
.\rabbitmq-plugins.bat list
```

---

## 🛠 Управление RabbitMQ как сервисом Windows

### Остановить

```powershell
net stop RabbitMQ
```

### Запустить

```powershell
net start RabbitMQ
```

### Проверить статус

```powershell
Get-Service rabbitmq
```

---

## 📂 Текущее состояние проекта

На данный момент в репозитории находится:

- часть серверной инфраструктуры;
- базовые наработки по админ-панели;
- инструкции по развёртыванию окружения;
- задел под дальнейшую разработку.

---

## 📉 Статус

> Когда-нибудь я это доделаю.

Пока что это:

- **архив идеи**
- **рабочий скелет**
- **технический черновик**
- **будущий кандидат на реанимацию**

---

## 🧠 Примечание

Этот репозиторий может быть полезен как:

- база для будущей административной панели;
- внутренняя заготовка под сервисную архитектуру;
- черновик под серверный инструмент для FLHook / Freelancer-инфраструктуры.
