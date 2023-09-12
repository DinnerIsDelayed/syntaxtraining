using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories
{
    internal class Linux
    {
        public string type = "Linux";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        public Linux()
        {
            problems = new List<Problem>()
            {
                // How to list files in a directory
                new Problem("How do you list files in a directory?", "ls", "The 'ls' command lists all files and directories in the specified directory.\nBy default, this command will list the content of the current directory."),

                // How to change directory
                new Problem("How do you change directory?", "cd DIRECTORY_NAME", "The 'cd' command changes the current directory to the one specified in the command.\nThis allows you to navigate through the file system."),

                // How to create a new directory
                new Problem("How do you create a new directory?", "mkdir DIRECTORY_NAME", "The 'mkdir' command creates a new directory with the specified name.\nThis is useful for organizing files and folders."),

                // How to remove a file
                new Problem("How do you remove a file?", "rm FILE_NAME", "The 'rm' command removes or deletes a file.\nBe cautious while using this command as it does not move the file to the Trash."),

                // How to remove a directory
                new Problem("How do you remove a directory?", "rmdir DIRECTORY_NAME", "The 'rmdir' command removes an empty directory.\nThe directory must be empty of both files and subdirectories."),

                // How to copy a file
                new Problem("How do you copy a file?", "cp SOURCE_FILE DESTINATION", "The 'cp' command copies a file from the source to the destination.\nThis is useful for creating backups or duplicates of files."),

                // How to move or rename a file
                new Problem("How do you move or rename a file?", "mv SOURCE DESTINATION", "The 'mv' command moves a file from the source to the destination.\nIt can also be used to rename a file."),

                // How to display the content of a file
                new Problem("How do you display the content of a file?", "cat FILE_NAME", "The 'cat' command concatenates and displays the content of files.\nThis is useful for quickly viewing simple text files."),

                // How to find the current directory you're in
                new Problem("How do you find the current directory you're in?", "pwd", "The 'pwd' command prints the fully qualified current working directory.\nThis is useful for understanding your location in the file system."),

                // How to search for a string in files
                new Problem("How do you search for a string in files?", "grep 'string' FILE_NAME", "The 'grep' command searches for a specific string in the specified file or files.\nThis is useful for finding occurrences of text within files."),

                // How to display the last part of a file
                new Problem("How do you display the last part of a file?", "tail FILE_NAME", "The 'tail' command displays the last part of a file.\nThis is commonly used for viewing the newest entries in log files."),

                // How to download a file from the internet
                new Problem("How do you download a file from the internet?", "wget URL", "The 'wget' command downloads files from the internet.\nIt supports downloading via HTTP, HTTPS, and FTP protocols."),

                // How to find the type of a file
                new Problem("How do you find the type of a file?", "file FILE_NAME", "The 'file' command determines the type of a file.\nThis can be useful for understanding how to handle a particular file."),

                // How to find the IP address of the current machine
                new Problem("How do you find the IP address of the current machine?", "ifconfig", "The 'ifconfig' command displays network configuration information.\nThis is useful for finding out the IP address of the machine."),

                // How to count lines, words, and characters in a file
                new Problem("How do you count lines, words, and characters in a file?", "wc FILE_NAME", "The 'wc' command stands for word count.\nIt counts lines, words, and characters in a specified file."),

                // How to create an empty file
                new Problem("How do you create an empty file?", "touch FILE_NAME", "The 'touch' command creates an empty file with the specified name.\nThis is useful for quickly creating new files."),

                // How to display the date and time
                new Problem("How do you display the date and time?", "date", "The 'date' command displays the current date and time.\nThis is useful for scripting and logging purposes."),

                // How to change file permissions
                new Problem("How do you change file permissions?", "chmod PERMISSIONS FILE_NAME", "The 'chmod' command changes the file mode bits of the specified file.\nThis is useful for setting or changing permissions on a file."),

                // How to display the manual page for a command
                new Problem("How do you display the manual page for a command?", "man COMMAND_NAME", "The 'man' command displays the manual or documentation for the specified command.\nThis is helpful for understanding how a particular command works."),

                // How to terminate a running process
                new Problem("How do you terminate a running process?", "kill PROCESS_ID", "The 'kill' command sends a signal to a process, effectively terminating it.\nThis is useful for stopping non-responsive or unwanted processes.")

            };

            for (int i = 0; i < problems.Count; i++)
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
