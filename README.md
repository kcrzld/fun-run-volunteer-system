# Fun Run Volunteer Assignment System

A Windows Forms application developed in C# that automates the assignment of volunteers to event booths for a Fun Run event using a simplified Hungarian Algorithm and SQL Server database integration.

---

## Project Overview

This system is designed to efficiently assign volunteers to different booths in a Fun Run event based on their preferences. It uses a quantitative method approach (Assignment Problem / Hungarian Algorithm) to ensure optimal matching between volunteers and booth slots.

The system helps organizers reduce manual scheduling effort and improve fairness in volunteer assignments.

---

## Features

- Volunteer Registration
- Preference Input System (DataGridView-based)
- SQL Server Database Integration
- Booth Management System
- Assignment Computation using Hungarian Algorithm (simplified implementation)
- Result Display (Volunteer-to-Booth assignment output)

---

## Algorithm Used

### Hungarian Algorithm (Assignment Problem)
The system applies a simplified Hungarian Method to minimize preference cost and assign volunteers to booths efficiently.

Steps implemented:
- Row reduction
- Column reduction
- Zero-based assignment matching
- Conflict-free assignment handling

---

## System Modules

### 1. Volunteer Registration
- Stores volunteer name in database

### 2. Preference Module
- Volunteers input preference scores for each booth

### 3. Computation Module
- Checks if required number of volunteers is met
- Builds cost matrix from preferences
- Runs Hungarian Algorithm

### 4. Assignment Module
- Saves final assignments to SQL database

### 5. Results Module
- Displays final volunteer-to-booth assignments

---

## 🗄️ Database Design

Tables used:

- `Volunteers (VolunteerID, VolunteerName)`
- `Booths (BoothID, BoothName, RequiredVolunteers)`
- `Preferences (PreferenceID, VolunteerID, BoothID, PreferenceScore)`
- `Assignments (AssignmentID, VolunteerID, BoothID)`

---

## Technologies Used

- C# (.NET Windows Forms)
- Microsoft SQL Server
- ADO.NET
- DataGridView (UI component)
- Hungarian Algorithm (custom implementation)


## 🚀 How to Run the Project

1. Clone the repository
```bash
git clone https://github.com/your-username/fun-run-volunteer-system.git
