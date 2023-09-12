using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories
{
    internal class Git
    {
        public string type = "Git";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        public Git() 
        {
            problems = new List<Problem>()
            {
                // How to clone a repository
                new Problem("How do you clone a repository?", "git clone REPO_URL", "The 'git clone' command clones (or copies) a repository from an existing URL.\nThis allows you to have a full copy of the code base on your local machine."),

                // How to initialize a new Git repository
                new Problem("How do you initialize a new Git repository?", "git init", "The 'git init' command initializes a new Git repository and starts tracking an existing directory.\nThis creates a new subdirectory named '.git' that contains all the necessary Git metadata."),

                // How to check the status of your changes
                new Problem("How do you check the status of your changes?", "git status", "The 'git status' command shows the status of changes in the working directory and staging area.\nIt lets you see which changes have been staged, which haven’t, and which files aren’t being tracked by Git."),

                // How to add changes to the staging area
                new Problem("How do you add changes to the staging area?", "git add FILENAME", "The 'git add' command adds changes in the specified files to the staging area.\nIt tells Git that you want to include the updates to the files in the next commit."),

                // How to commit your changes
                new Problem("How do you commit your changes?", "git commit -m 'Your message here'", "The 'git commit' command captures a snapshot of the changes in the staging area.\nThe '-m' flag allows you to include an inline commit message."),

                // How to push your changes to a remote repository
                new Problem("How do you push your changes to a remote repository?", "git push REMOTE_NAME BRANCH_NAME", "The 'git push' command pushes the changes from the local line to the remote repository defined with REMOTE_NAME and BRANCH_NAME.\nThis allows other people to see the changes you have made."),

                // How to pull changes from a remote repository
                new Problem("How do you pull changes from a remote repository?", "git pull REMOTE_NAME BRANCH_NAME", "The 'git pull' command fetches changes made in a remote repository and merges them into your local repository.\nThis is a combination of 'git fetch' and 'git merge'."),

                // How to create a new branch
                new Problem("How do you create a new branch?", "git branch BRANCH_NAME", "The 'git branch' command creates a new branch with the given name.\nThis allows you to isolate changes without affecting other branches."),

                // How to switch to a different branch
                new Problem("How do you switch to a different branch?", "git checkout BRANCH_NAME", "The 'git checkout' command switches branches by updating the index, working tree, and HEAD to reflect the chosen branch."),

                // How to merge a branch into another
                new Problem("How do you merge a branch into another?", "git merge BRANCH_NAME", "The 'git merge' command merges the specified branch’s history into the current working branch.\nThis is a way to combine work between different branches."),

                // How to delete a branch
                new Problem("How do you delete a branch?", "git branch -d BRANCH_NAME", "The 'git branch -d' command deletes a specified branch.\nThe '-d' option will delete the branch only if it has already been fully merged in its upstream branch."),

                // How to stash changes
                new Problem("How do you stash changes?", "git stash", "The 'git stash' command temporarily saves changes that have not been committed so that you can switch to another branch.\nYou can apply the stashed changes later."),

                // How to apply stashed changes
                new Problem("How do you apply stashed changes?", "git stash apply", "The 'git stash apply' command reapplies the changes stored in a stash.\nThis restores the changes that were stashed away."),

                // How to show the commit history
                new Problem("How do you show the commit history?", "git log", "The 'git log' command shows the commit history of a repository.\nThis is useful for understanding the changes made in the project over time."),

                // How to show changes between commits
                new Problem("How do you show changes between commits?", "git diff COMMIT1_ID COMMIT2_ID", "The 'git diff' command shows differences between two commits.\nThis can be useful for code reviews and to understand changes."),

                // How to revert a commit
                new Problem("How do you revert a commit?", "git revert COMMIT_ID", "The 'git revert' command creates a new commit that undoes changes from a specified commit.\nThis is a safe way to undo changes as it doesn't alter the existing history."),

                // How to resolve merge conflicts
                new Problem("How do you resolve merge conflicts?", "Manually edit conflicted files, then git add.", "To resolve merge conflicts, you'll need to manually edit the conflicted files to fix the inconsistencies.\nAfter that, use 'git add' to stage the resolved files for commit."),

                // How to tag a commit
                new Problem("How do you tag a commit?", "git tag TAG_NAME", "The 'git tag' command assigns a tag to a specified commit.\nTags are references to specific points in Git history and are often used to capture a point in history that is used for a marked version (e.g., v1.0.1)."),

                // How to rebase a branch
                new Problem("How do you rebase a branch?", "git rebase BRANCH_NAME", "The 'git rebase' command moves or combines a sequence of commits to a new base commit.\nIt's a way to integrate changes from one branch into another without creating a merge commit."),

                // How to clone a specific branch
                new Problem("How do you clone a specific branch?", "git clone -b BRANCH_NAME REPO_URL", "The 'git clone -b' command clones a specific branch from a remote repository.\nThe '-b' flag specifies which branch you want to clone.")
            };

            for (int i = 0; i < problems.Count; i++)
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
