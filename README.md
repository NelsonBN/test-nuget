# test-nuget
Test nuget project


## Conditional compilation
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives

## github package nuget
https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-to-github-packages



## sourcelink
https://docs.microsoft.com/pt-br/dotnet/standard/library-guidance/sourcelink
https://github.com/dotnet/sourcelink
https://devblogs.microsoft.com/dotnet/improving-debug-time-productivity-with-source-link/


## tests multi frameworks
https://docs.github.com/en/actions/using-jobs/using-a-matrix-for-your-jobs
https://devblogs.microsoft.com/dotnet/dotnet-loves-github-actions/







-------
https://github.com/commitizen/cz-cli

```bash
npm install -g commitizen
npm init -y
commitizen init cz-conventional-changelog --save-dev --save-exact
npm install husky
```


on package.json:
```json
"scripts": {
    "commit": "cz"
},
"husky": {
  "hooks": {
    "prepare-commit-msg": "exec < /dev/tty && npx cz --hook || true"
  }
}
```


## Version
https://semver.org/


https://semantic-release.gitbook.io/semantic-release/
https://semantic-release.gitbook.io/semantic-release/support/faq#how-can-i-change-the-type-of-commits-that-trigger-a-release