# PawTrace

**PawTrace** is a simple Windows Forms application designed to help people register and track lost or found pets.  
The app allows users to insert information about lost or found animals and view existing entries in a structured, easy-to-use desktop environment.  

The goal of the project is to create a caring community where collaboration leads to more happy reunions between pets and their owners.

---

## Project Description

PawTrace simplifies the process of reporting lost or found pets through a desktop application.  
Users can input details, browse records, and manage pet listings efficiently. The application includes forms for reporting lost and found pets, a simple interface for browsing entries, and basic user management.

---

## Features

### Home Screen
- Overview of the application.
- Navigation to:
  - Lost Pet Form
  - Found Pet Form
  - View Listings
- Displays recent entries for lost and found pets.

### Found Animal Form
Users can submit details for a found pet:
- Type of animal, breed (if known), gender, color, approximate age.
- Location where the animal was found.
- Date and time of discovery.
- Optional photo upload.

### Lost Animal Form
Users can report a lost pet:
- Pet’s name (if known), type, breed, color, and approximate age.
- Last known location.
- Date and time of disappearance.
- Photo and description.

### Listings View
- Displays all lost and found pet entries.
- Filter by type, breed, location, and date.
- View detailed information for each listing.

### User Management
- Users can register with a name, email, and phone number.
- Two user roles:
  - **Regular User** – can submit, edit, and track their own entries.
  - **Administrator** – can view, edit, and delete all entries.

### Administrator Dashboard
- Overview of all pet listings.
- Manage users and roles.
- Approve or remove entries.

---

## Technologies Used

| Category               | Technology                    |
|------------------------|-------------------------------|
| Desktop Framework      | Windows Forms (.NET)          |
| Backend/Logic          | C#                            |
| Database               | SQLite / Local Database       |
| Development Environment| Visual Studio                 |
| Hosting/Distribution   | Local Windows Application     |

---

## Getting Started

1. Clone or download the repository.
2. Open the solution file in Visual Studio.
3. Build the project.
4. Run `PawTrace.exe` to start the application.
5. Use the Home Screen to navigate and add/view lost or found pets.
