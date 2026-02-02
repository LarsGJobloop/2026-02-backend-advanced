terraform {
  required_providers {
    github = {
      source  = "integrations/github"
      version = "6.10.2"
    }
  }
}

variable "github_token" {
  description = "The API token for managing the repository"
  type        = string
  sensitive   = true
}

provider "github" {
  token = var.github_token
}

resource "github_repository" "repository" {
  name       = "2026-02-backend-advanced"
  visibility = "public"

  # Features
  has_issues   = true
  has_projects = true
  has_wiki     = true
}
