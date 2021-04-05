Read Working In a Professional Environment > Github Actions and How to Use Them and answer the following questions
s
What is a Github action and how do they work?
``
The way it works is that you create actions in your repositories by creating one or more text files. These are called workflows.
``
What benefits do Github actions provide?
``
Workflows can handle common build tasks, like continuous delivery and continuous integration. That means that you can use an action to compress images, test your code, and push the site to your hosting platform when the master branch changes.
``

What types of trigger actions can a workflow use? What do they do?
``
They can use Push, Pull, Fork, or Webhook requests. Push updates your changes to Github, Pull allows others to get the changes, Fork allows others to get your code, and Webhook updates you when a web-activity happens to your repository (i.e, its starred)
``