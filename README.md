# -apbd-cw1-git-s31378

## Task 5
This commit was added directly on main before merging feature-max.

## Task 6
This commit was added on main before rebasing feature-min.

## Git Concepts

### 1. When does Git perform a fast-forward and when is a merge commit created?

Git performs a fast-forward merge when the target branch (main) has no new commits since the feature branch was created. In this case, Git moves the branch pointer forward without creating a new commit.

A merge commit is created when both branches have new commits. Git cannot fast-forward, so it creates a new merge commit to combine the histories of both branches.

---

### 2. What is the practical difference between merge and rebase?

Merge preserves the history of both branches and creates a merge commit, which shows how branches were combined.

Rebase rewrites the history of a branch by applying its commits on top of another branch. This results in a cleaner, linear history without merge commits.

---

### 3. How was the conflict resolved in your repository?

The conflict occurred because the same part of the code was modified differently in the main branch and the feature-conflict branch.

I resolved the conflict manually by editing the conflicted section, removing the conflict markers, and choosing a final version of the code that preserves correct functionality.