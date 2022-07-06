# test-nuget
Test nuget project

[![Commitizen friendly](https://img.shields.io/badge/commitizen-friendly-brightgreen.svg)](http://commitizen.github.io/cz-cli/)

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


## Commits pattern
https://github.com/conventional-changelog/commitlint




-------
https://github.com/commitizen/cz-cli

```bash
npm install -g commitizen
npm init -y
commitizen init cz-conventional-changelog --save-dev --save-exact --force
```



https://marketplace.visualstudio.com/items?itemName=vivaxy.vscode-conventional-commits
https://marketplace.visualstudio.com/items?itemName=mrluje.vs-commitizen


```bash
npm install --save-dev husky
# npx semantic-release-cli setup
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

https://github.com/angular/angular/blob/main/CONTRIBUTING.md


```sh
npm install --save-dev @commitlint/config-conventional @commitlint/cli

echo "module.exports = {extends: ['@commitlint/config-conventional']}" > commitlint.config.js


npm install husky --save-dev
```




npm init -y
npx husky-init

npx husky add .husky/commit-msg 'echo "pre."'