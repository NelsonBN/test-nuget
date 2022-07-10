

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


## Semantic Versioning
https://www.conventionalcommits.org/en/v1.0.0/


https://semver.org/

https://semantic-release.gitbook.io/semantic-release/
https://semantic-release.gitbook.io/semantic-release/support/faq#how-can-i-change-the-type-of-commits-that-trigger-a-release

https://github.com/angular/angular/blob/main/CONTRIBUTING.md




--------
```bash
npm init -y
npm install husky --save-dev
npx husky-init
npx husky add .husky/commit-msg 'echo "TODO"'
```

```bash
#!/usr/bin/env sh
if ! head -1 "$1" | grep -qE "^(build|chore|ci|docs|feat|fix|perf|refactor|revert|style|test|merge)(\(.+?\))?(\!)?: .{3,}$"; then
    echo "Aborting commit. Your commit message is invalid. See some examples below:" >&2
    echo "feat(logging): added logs for failed signups" >&2
    echo "fix(homepage): fixed image gallery" >&2
    echo "test(homepage): updated tests" >&2
    echo "docs(readme): added new logging table information" >&2
    echo "For more information check https://www.conventionalcommits.org/en/v1.0.0/ for more details" >&2
    exit 1
fi
if ! head -1 "$1" | grep -qE "^.{9,85}$"; then
    echo "Aborting commit. Your commit message is too long. Max length is 89 characters" >&2
    exit 1
fi
```

```bash
npm install -g commitizen
commitizen init cz-conventional-changelog --save-dev --save-exact --force
npx husky add .husky/prepare-commit-msg "exec < /dev/tty && git cz --hook || true”
```

https://github.com/commitizen/cz-cli

https://marketplace.visualstudio.com/items?itemName=vivaxy.vscode-conventional-commits
https://marketplace.visualstudio.com/items?itemName=mrluje.vs-commitizen



```bash
npm install -D semantic-release @semantic-release/changelog @semantic-release/git
```

https://github.com/settings/tokens/new?scopes=repo
https://github.com/semantic-release/semantic-release/blob/c69445ebea7dcdf8038c20e36864d3c11c87adf4/docs/recipes/ci-configurations/github-actions.md


https://npmmirror.com/package/semantic-release-plugin-csproj
```bash
npm install -D semantic-release-plugin-csproj
```

https://github.com/semantic-release/github/issues/175




### images url
https://docs.microsoft.com/en-gb/nuget/nuget-org/package-readme-on-nuget-org#allowed-domains-for-images-and-badges