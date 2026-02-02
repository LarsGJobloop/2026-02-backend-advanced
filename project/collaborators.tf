resource "github_repository_collaborator" "name" {
  repository = github_repository.repository.name

  username   = "zabronax"
  permission = "pull"
}
