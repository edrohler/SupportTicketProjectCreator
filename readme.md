# Support Ticket Project Creator

A command-line utility for creating support ticket project repositories and adding them to source code.

## Description

I create a lot of support ticket projects and follow a pretty strict order of operations.

I usually have to type this out in the command line but this automates the commands.

### Example

An example would be if I was creating a new project for a support product widgets with ticket id 123.

Note that `tix-widg` is a msalias I have set in my command prompt that navigates me to my ticket repositories. See the following command line:

`tix-widg && git checkout -b 123 && cd [path or msalias to repo]\tickets && mkdir 123 && cd 123 && dotnet new sln && mkdir ref src kb kb\img && git add -A && git commit -m init`

## Usage

Assuming I have the sptc in my path, from the example above I would instead run the following:

`stpc 123 widget -n true`
