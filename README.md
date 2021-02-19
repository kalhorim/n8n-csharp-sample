# Sample project to call [n8n](https://n8n.io/) workflow.

In this repository, a simple example has been created to communicate with the Workflow Automation Tool n8n.

first run n8n (I recommend using docker image) but depend on you please read n8n documentation.

```cmd

docker run -it --rm --name n8n 	-p 5678:5678 -v c:\{yourpath}:/home/node/.n8n n8nio/n8n

```
get this repo

```
git clone https://github.com/kalhorim/n8n-csharp-sample.git
```

copy content of file [src/Webapp/n8nWfs/createUser.json](src/Webapp/n8nWfs/createUser.json) to new workflow in http://localhost:5678/

compile and run project.

https://kalhorim.ir
