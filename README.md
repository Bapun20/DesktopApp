# Desktop Application

This is a Windows Forms Application that replicates the functionality of Google Forms.

## Features

- **Create New Submission**: Allows users to create new submissions with fields for Name, Email, Phone Number, and GitHub repo link.
- **View Submissions**: Allows users to view submitted forms one by one with options to navigate to the previous or next submission.
- **Stopwatch**: Includes a stopwatch feature that can be paused and resumed without resetting.
- **Keyboard Shortcuts**: Supports keyboard shortcuts for quick navigation and actions.

## Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/Bapun20/DesktopApp.git
    ```

2. Open the project in Visual Studio.

3. Build and run the application.

## Usage

### Form1 - Main Form

- **Overview**: The main form with two buttons - "View Submissions" and "Create New Submission".
- **Actions**:
  - **View Submissions**: Opens the View Submissions form.
    - Button: Click the "View Submissions" button.
    - Keyboard Shortcut: Press `Ctrl + V` to open the View Submissions form.
  - **Create New Submission**: Opens the Create Submission form.
    - Button: Click the "Create New Submission" button.
    - Keyboard Shortcut: Press `Ctrl + N` to open the Create Submission form.

### Create New Submission

- **Overview**: Allows users to create new submissions.
- **Fields**:
  - Name
  - Email
  - Phone Number
  - GitHub Repo Link
- **Actions**:
  - **Submit**: Submits the form data to the backend server.
    - Button: Click the "Submit" button.
    - Keyboard Shortcut: Press `Ctrl + S` to submit the form.
  - **Toggle Stopwatch**: Starts or pauses the stopwatch without resetting.
    - Button: Click the "Toggle Stopwatch" button.
    - Keyboard Shortcut: Press `Ctrl + T` to start/pause the stopwatch.

### View Submissions

- **Overview**: Allows users to view previously submitted forms.
- **Actions**:
  - **Previous**: Navigates to the previous submission.
    - Button: Click the "Previous" button.
    - Keyboard Shortcut: Press `Ctrl + P` to view the previous submission.
  - **Next**: Navigates to the next submission.
    - Button: Click the "Next" button.
    - Keyboard Shortcut: Press `Ctrl + N` to view the next submission.
  - **Delete**: Deletes the current submission.
    - Button: Click the "Delete" button.
    - Keyboard Shortcut: Press `Ctrl + D` to delete the current submission.

## Contributing

Contributions are welcome! Please create a pull request or open an issue to discuss changes.

## License

This project is licensed under the MIT License.
