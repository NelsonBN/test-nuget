# Contributing

Here are some helpful guidelines to keep in mind when contributing. While following them isn't absolutely required, it does help everyone to accept your pull-requests with maximum awesomeness.


## General Seps

1. Check if there is already an open issue for the subject;
2. Open an issue to discuss the new feature;
3. Fork this repository;
4. Create your feature branch: `git checkout -b feature/my-new-feature`;
5. Add files changed:  `git add --all`;
6. Commit your changes: `git commit -m "Add some feature"`;
7. Push to the branch: `git push origin feature/my-new-feature`;
8. Submit a pull request;


## Commits and Pull Requests (PR)
* :heavy_check_mark: **DO** keep pull requests small so they can be easily reviewed.
* :heavy_check_mark: **DO** atomic commits to make it easier to analyze changes.
* :x: **AVOID** breaking the continuous integration build.


## Coding Standards
* :heavy_check_mark: **DO** add XML comment documentation to new classes, methods or parameters.
* :heavy_check_mark: **DO** add a test class for each feature and a test method for each 
* :heavy_check_mark: **DO** use language conventions to make code easy to understand quickly
  * See some tips here: [dofactory](https://www.dofactory.com/csharp-coding-standards);
* :heavy_check_mark: **CONSIDER** using SOLID patterns;


## Tests
* :heavy_check_mark: **DO** add a unit test if your Pull Requests resolves an issue or adds features.
* :heavy_check_mark: **CONSIDER** using test patterns like "AAA" and "Given When Then";
* :heavy_check_mark: **DO** add a test class for each feature and a test method for each assertion;
* :heavy_check_mark: **DO** make sure unit tests pass.
* :x: **AVOID** adding tests just to get coverage on sonarcloud.

### Disclaimer
- 1️⃣ Unit in Unit Test is not a method/function.
- 2️⃣ One assertion per test doesn't mean invoking the Assert method only once.
> by @gsferreira
