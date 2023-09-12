using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories
{
    internal class Docker
    {
        public string type = "Docker";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        public Docker()
        {
             problems = new List<Problem>()
            {
                // How to pull an image from Docker Hub
                new Problem("How do you pull an image from Docker Hub?", "docker pull IMAGE_NAME", "The 'docker pull' command fetches a Docker image from a registry like Docker Hub.\nThis allows you to download images that you can later run as containers on your machine."),

                // How to list all Docker images on your machine
                new Problem("How do you list all Docker images on your machine?", "docker images", "The 'docker images' command lists all Docker images that are currently stored on your local machine.\nThis helps you to manage space and understand what images you have available."),

                // How to run a Docker container
                new Problem("How do you run a Docker container?", "docker run IMAGE_NAME", "The 'docker run' command creates and starts a container from a specified image.\nThis is essential for deploying applications in Docker."),

                // How to list running Docker containers
                new Problem("How do you list running Docker containers?", "docker ps", "The 'docker ps' command lists all running Docker containers.\nThis shows you the containers that are currently active, their status, ports, and other useful information."),

                // How to stop a Docker container
                new Problem("How do you stop a Docker container?", "docker stop CONTAINER_ID", "The 'docker stop' command stops a running container.\nYou'll need to specify the container ID or name, which you can find using 'docker ps'."),

                // How to remove a Docker container
                new Problem("How do you remove a Docker container?", "docker rm CONTAINER_ID", "The 'docker rm' command removes a stopped container from your machine.\nYou'll need to stop the container first using 'docker stop'."),

                // How to execute a command in a running Docker container
                new Problem("How do you execute a command in a running Docker container?", "docker exec CONTAINER_ID COMMAND", "The 'docker exec' command allows you to execute a command in a running container.\nThis is useful for debugging or managing processes within a container."),

                // How to build a Docker image from a Dockerfile
                new Problem("How do you build a Docker image from a Dockerfile?", "docker build -t IMAGE_NAME .", "The 'docker build' command builds a Docker image from a Dockerfile located in the current directory.\nThe '-t' flag lets you tag your image with a name."),

                // How to push a Docker image to Docker Hub
                new Problem("How do you push a Docker image to Docker Hub?", "docker push IMAGE_NAME", "The 'docker push' command uploads your Docker image to a specified registry, like Docker Hub.\nBefore you push an image, make sure to tag it with the registry's URL."),

                // How to pull all image layers of a Docker image
                new Problem("How do you pull all image layers of a Docker image?", "docker pull --all-tags IMAGE_NAME", "The 'docker pull --all-tags' command pulls all tagged versions of a specified Docker image.\nThis is useful if you want to download multiple versions of an image at once."),

                // How to view logs for a Docker container
                new Problem("How do you view logs for a Docker container?", "docker logs CONTAINER_ID", "The 'docker logs' command fetches the logs of a container.\nThis is useful for debugging or understanding the behavior of a container."),

                // How to copy files from Docker container to host
                new Problem("How do you copy files from Docker container to host?", "docker cp CONTAINER_ID:/path/in/container /path/on/host", "The 'docker cp' command copies files or directories between a container and the local filesystem.\nUseful for exporting data, logs or other information from a container."),

                // How to inspect a Docker container
                new Problem("How do you inspect a Docker container?", "docker inspect CONTAINER_ID", "The 'docker inspect' command provides detailed information about a container in JSON format.\nThis can include configuration details, status, and network settings among other things."),

                // How to tag a Docker image
                new Problem("How do you tag a Docker image?", "docker tag SOURCE_IMAGE TARGET_IMAGE", "The 'docker tag' command assigns a new alias to an existing Docker image.\nThis is useful when you want to push the image to a different registry or as a different version."),

                // How to remove all unused Docker objects
                new Problem("How do you remove all unused Docker objects?", "docker system prune -a", "The 'docker system prune -a' command removes all unused containers, networks, images (both dangling and unreferenced), and optionally, volumes.\nThis helps in freeing up disk space."),

                // How to start a stopped Docker container
                new Problem("How do you start a stopped Docker container?", "docker start CONTAINER_ID", "The 'docker start' command starts a stopped container.\nUseful for restarting containers after a machine reboot or after intentionally stopping them."),

                // How to update configuration of a Docker container without stopping it
                new Problem("How to update configuration of a Docker container without stopping it?", "docker update CONTAINER_ID", "The 'docker update' command dynamically updates container configurations without stopping the container.\nThis can include memory limits, CPU shares, and other settings."),

                // How to view the version of Docker installed
                new Problem("How do you view the version of Docker installed?", "docker --version", "The 'docker --version' command displays the installed Docker version.\nUseful for debugging and ensuring you have the correct version installed."),

                // How to save a Docker container as a new image
                new Problem("How do you save a Docker container as a new image?", "docker commit CONTAINER_ID NEW_IMAGE_NAME", "The 'docker commit' command creates a new image from a container’s changes.\nUseful for debugging or for creating new images based on customized containers."),

                // How to search Docker Hub for images
                new Problem("How do you search Docker Hub for images?", "docker search TERM", "The 'docker search' command searches Docker Hub for images that match the search term.\nThis is useful when you're looking for images to use as a base for your own containers.")
            };

            for (int i = 0; i < problems.Count; i++)
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
